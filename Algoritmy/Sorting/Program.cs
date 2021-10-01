using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 10;

            int[] originalArray = new int[ARRAY_SIZE];
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = new Random().Next(-10, 10);
            }
            //Array.ForEach<int>(originalArray, x => x = new Random().Next(-10, 10));

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();

            RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();

            PrintArray(originalArray);
            stopWatch.Start();
            SelectionSort(originalArray);            
            Console.WriteLine("SelectionSort duration {0} ms", stopWatch.Elapsed.TotalMilliseconds);
            if (!IsSorted(originalArray)) Console.WriteLine("Array is not sorted !!!");
            stopWatch.Reset();

            PrintArray(originalArray);
            originalArray = new int[ARRAY_SIZE];
            originalArray = originalArray.OrderBy(x => Next(random)).ToArray();
            PrintArray(originalArray);
            if (IsSorted(originalArray)) Console.WriteLine("Array is sorted !!!");
            stopWatch.Start();
            BubbleSort(originalArray);
            Console.WriteLine("BubbleSort duration {0} ms", stopWatch.Elapsed.TotalMilliseconds);
            if (!IsSorted(originalArray)) Console.WriteLine("Array is not sorted !!!");
            stopWatch.Reset();

            originalArray = new int[ARRAY_SIZE];
            Array.ForEach<int>(originalArray, x => x = new Random().Next(-ARRAY_SIZE, ARRAY_SIZE));
            stopWatch.Start();
            InsertionSort(originalArray);
            Console.WriteLine("InsertionSort duration {0} ms", stopWatch.Elapsed.TotalMilliseconds);
            if (!IsSorted(originalArray)) Console.WriteLine("Array is not sorted !!!");
            stopWatch.Reset();

            originalArray = new int[ARRAY_SIZE];
            Array.ForEach<int>(originalArray, x => x = new Random().Next(-ARRAY_SIZE, ARRAY_SIZE));
            stopWatch.Start();
            HeapSort(originalArray);
            Console.WriteLine("HeapSort duration {0} ms", stopWatch.Elapsed.TotalMilliseconds);
            if (!IsSorted(originalArray)) Console.WriteLine("Array is not sorted !!!");
            stopWatch.Reset();

            originalArray = new int[ARRAY_SIZE];
            Array.ForEach<int>(originalArray, x => x = new Random().Next(-ARRAY_SIZE, ARRAY_SIZE));
            stopWatch.Start();
            MergeSort(originalArray);
            Console.WriteLine("MergeSort duration {0} ms", stopWatch.Elapsed.TotalMilliseconds);
            if (!IsSorted(originalArray)) Console.WriteLine("Array is not sorted !!!");
            stopWatch.Reset();

            originalArray = new int[ARRAY_SIZE];
            Array.ForEach<int>(originalArray, x => x = new Random().Next(-ARRAY_SIZE, ARRAY_SIZE));
            stopWatch.Start();
            QuickSort(originalArray, 0, originalArray.Length - 1);
            Console.WriteLine("QuickSort duration {0} ms", stopWatch.Elapsed.TotalMilliseconds);
            if (!IsSorted(originalArray)) Console.WriteLine("Array is not sorted !!!");
            stopWatch.Reset();

            Console.ReadKey();
        }

        static int Next(RNGCryptoServiceProvider random)
        {
            byte[] randomInt = new byte[4];
            random.GetBytes(randomInt);
            return Convert.ToInt32(randomInt[0]);
        }

        static void PrintArray(int[] array) 
        {
            foreach (int i in array)
                Console.Write(i);
            Console.WriteLine();
        }

        /*
        Selection sort je jedním z nejjednodušších řadících algoritmů. 
        Jeho myšlenka spočívá v nalezení minima, které se přesune na začátek pole (nebo můžeme hledat i maximum a to dávat na konec). 
        V prvním kroku tedy nalezneme nejmenší prvek v poli a ten poté přesuneme na začátek. 
        V druhém kroku již nebudeme při hledání minima brát v potaz dříve nalezené minimum. 
        Po dostatečném počtu kroků dostaneme pole seřazené. 
        Algoritmus má nepříliš výhodnou časovou složitost a není stabilní. 
        Je však velice jednoduchý na pochopení i implementaci.
         */
        public static void SelectionSort(int[] list)
        {
            int temp, min;
            for (int i = 0; i < (list.Length - 1); i++)
            {
                min = list.Length - 1;
                // hledani minima
                for (int j = i; j < (list.Length - 1); j++)
                    if (list[min] > list[j])
                        min = j;
                // prohozeni prvku
                temp = list[min];
                list[min] = list[i];
                list[i] = temp;
            }
        }

        /*
        Bubble sort je poměrně hloupý algoritmus, který se vyskytuje v podstatě jen v akademickém světě. 
        Nemá žádné dobré vlastnosti a je zajímavý pouze svým průběhem, který může připomínat fyzikální nebo přírodní jevy. 
        Algoritmus probíhá ve vlnách, přičemž při každé vlně propadne "nejtěžší" prvek na konec (nebo nejlehčí vybublá nahoru, záleží na implementaci). 
        Vlna porovnává dvojice sousedních prvků a v případě, že je levý prvek větší než pravý, prvky prohodí. 
        Algoritmus je stabilní.
         */
        public static void BubbleSort(int[] list)
        {
            int j = list.Length - 2, temp;
            // kontrola prohozeni
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i <= j; i++)
                {
                    // prohozeni
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        swapped = true;
                    }
                }
                j--;
            }
        }

        /*
        Insertion sort vidí pole rozdělené na 2 části - setříděnou a nesetříděnou. 
        Postupně vybírá prvky z nesetříděné části a vkládá je mezi prvky v setříděné části tak, aby zůstala setříděná. 
        Od toho jeho jméno - vkládá prvek přesně tam, kam patří a nedělá tedy žádné zbytečné kroky, jako například Bubble sort.
         */
        public static void InsertionSort(int[] list)
        {
            int item, j;
            for (int i = 1; i <= (list.Length - 1); i++)
            {
                // ulozeni prvku
                item = list[i];
                j = i - 1;
                while ((j >= 0) && (list[j] > item))
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = item;
            }
        }

        //Heapsort
        //oprava haldy nahoru
        public static void Up(int[] list, int i)
        {
            int child = i; //ulozim syna
            int parent, temp;
            while (child != 0)
            {
                parent = (child - 1) / 2; //otec
                if (list[parent] < list[child])
                { //detekce chyby
                    temp = list[parent]; //prohozeni syna s otcem
                    list[parent] = list[child];
                    list[child] = temp;
                    child = parent; //novy syn
                }
                else
                    return; //ok
            }
        }

        //oprava haldy dolu
        public static void Down(int[] list, int last)
        {
            int parent = 0;
            int child, temp;
            while (parent * 2 + 1 <= last)
            {
                child = parent * 2 + 1;
                //pokud je vybran mensi syn
                if ((child < last) && (list[child] < list[child + 1]))
                    child++; //vybereme toho vetsiho
                if (list[parent] < list[child])
                { //detekce chyby
                    temp = list[parent]; //prohozeni syna s otcem
                    list[parent] = list[child];
                    list[child] = temp;
                    parent = child; //novy otec
                }
                else
                    return;
            }
        }

        // postaveni haldy z pole
        public static void Heapify(int[] list)
        {
            for (int i = 1; i < list.Length; i++)
                Up(list, i);
        }

        // samotne trideni
        public static void HeapSort(int[] list)
        {
            Heapify(list);
            int index = list.Length - 1; //posledni prvek
            int temp;
            while (index > 0)
            {
                temp = list[0]; // prohození posledního prvku s maximem
                list[0] = list[index];
                list[index] = temp;
                index -= 1; //nastaveni noveho posledniho prvku
                Down(list, index);
            }
        }

        /*
        Merge sort je algoritmus, založený na tzv. principu rozděl a panuj (latinsky divide et impera, anglicky divide and conquer). 
        To znamená, že pokud nějaký problém neumíme vyřešit v celku, rozložíme si ho na více menších a jednodušších problémů. 
        Ten samý postup aplikujeme i na tyto problémy (opět je rozdělíme na ještě menší, mimochodem velmi se zde nabízí rekurzivní řešení) až se dostaneme
        na takovou úroveň, kterou jsme schopni bez problému řešit. 
        V problému třídění se často chceme dostat až k poli velikosti 1, které považujeme automaticky za setříděné.
         */
        // sliti dvou setridenych poli do jednoho
        public static void Merge(int[] list, int[] left, int[] right)
        {
            int i = 0;
            int j = 0;
            // dokud nevyjedeme z jednoho z poli
            while ((i < left.Length) && (j < right.Length))
            {
                // dosazeni toho mensiho prvku z obou poli a posunuti indexu
                if (left[i] < right[j])
                {
                    list[i + j] = left[i];
                    i++;
                }
                else
                {
                    list[i + j] = right[j];
                    j++;
                }
            }
            // doliti zbytku z nevyprazdneneho pole
            if (i < left.Length)
            {
                while (i < left.Length)
                {
                    list[i + j] = left[i];
                    i++;
                }
            }
            else
            {
                while (j < right.Length)
                {
                    list[i + j] = right[j];
                    j++;
                }
            }
        }

        // samotne trideni
        public static void MergeSort(int[] list)
        {
            if (list.Length <= 1) //podmínka rekurze
                return;
            int center = list.Length / 2; //stred pole
            int[] left = new int[center]; //vytvoreni a naplneni leveho pole
            for (int i = 0; i < center; i++)
                left[i] = list[i];
            int[] right = new int[list.Length - center]; //vytvoreni a naplneni praveho pole
            for (int i = center; i < list.Length; i++) //vytvoreni a naplneni praveho pole
                right[i - center] = list[i];
            MergeSort(left); // rekurzivni zavolani na obe nova pole
            MergeSort(right);
            Merge(list, left, right); //sliti poli
        }

        /*
        Quicksort si označí jeden prvek v poli jako tzv. pivot. 
        Výběrem pivotu se prozatím nebudeme zabývat a budeme jako pivot brát vždy první prvek v poli. 
        Nyní zavoláme funkci divide (rozděl), která přeuspořádá pole tak, aby byly zleva prvky menší než pivot, poté následovat pivot sám a za pivotem byly prvky větší, než je on sám. 
        Povšimněte si, že jsem napsal přeuspořádá, nikoli setřídí. Prvky jsou tedy mezi sebou stále rozházené a jediné setřídění spočívá v jejich rozdělení pivotem.
         */
        // preusporada pole na prvky mensi nez pivot, pivot a prvky vetsi nez pivot
        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        public static bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

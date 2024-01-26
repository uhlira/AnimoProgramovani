<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="LocalhostChatServer.Chat" %>

<!DOCTYPE html>
<html>
<head>
    <title>Chat</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(function () {
            var chatHub = $.connection.chatHub;

            $.connection.hub.start().done(function () {
                $('#sendButton').click(function () {
                    var message = $('#messageInput').val();
                    chatHub.server.sendMessage(message);
                    $('#messageInput').val('');
                });
            });

            chatHub.client.broadcastMessage = function (message) {
                $('#chatMessages').append('<li>' + message + '</li>');
            };
        });
    </script>
</head>
<body>
    <div>
        <ul id="chatMessages"></ul>
        <input type="text" id="messageInput" />
        <input type="button" id="sendButton" value="Send" />
    </div>
</body>
</html>

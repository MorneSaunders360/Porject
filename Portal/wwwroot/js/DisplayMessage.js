function DisplayMessage(MesssageContent, MessageTitle, MessageType, functionName) {
    MessageType = typeof MessageType !== 'undefined' ? MessageType : 3;

    if (MessageTitle == '' || MessageTitle == undefined) {
        if (MessageType==1) {
            MessageTitle = 'Delete';
        } else if (MessageType == 2) {
            MessageTitle = 'Warning';
        } else if (MessageType == 3) {
            MessageTitle = 'Info';
        }

    }
    if (MesssageContent == '' || MesssageContent == undefined) {
        if (MessageType == 1) {
            MesssageContent = 'Delete content message';
        } else if (MessageType == 2) {
            MesssageContent = 'Warning content message';
        } else if (MessageType == 3) {
            MesssageContent = 'Info content message';
        }
        
    }
    switch (MessageType) {
        case 1://Delete Message
            $.confirm({
                title: MessageTitle,
                content: MesssageContent,
                theme: 'material',
                typeAnimated: true,
                buttons: {
                    Yes: {
                        text: 'Yes',
                        btnClass: 'btn-command',
                        action: function () {
                            eval(functionName)
                        }
                    },
                    close: {
                        text: 'Close',
                        btnClass: 'btn-command',
                        action: function () {

                        }

                    }
                }
            });
            break;
        case 2: // Warning message

            $.confirm({
                icon: 'fa fa-exclamation-triangle',
                title: MessageTitle,
                content: MesssageContent,
                theme: 'material',
                typeAnimated: true,
                buttons: {
                    text: 'Okay',
                    Okay: {
                        btnClass: 'btn-command',
                        action: function () {
                            eval(functionName)
                        }}
                }
            });
            break;

        case 3://Info Message
            $.confirm({
                icon: 'fa fa-info-circle',
                title: MessageTitle,
                content: MesssageContent,
                theme: 'material',
                typeAnimated: true,
                buttons: {
                    text: 'Okay',
                    Okay: {
                        btnClass: 'btn-command',
                        action: function () {
                            eval(functionName)
                        }
                    }
                }
            });
            break;

    }

  
}


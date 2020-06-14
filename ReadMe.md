[image1]: ./Images/wamp-server-httpd-vhosts.conf.jpg "wamp-server-httpd-vhosts.conf"
[image2]: ./Images/Result.png "Result"
[image3]: ./Images/menu-item.png "NGROK"


# How to run
## WampServer
You may tend to run this project under Linux OS or WAMP server. So you should extract the HTML/CSS and Javascript file and run all of them independently. If you can so download this repository. Then run your wamp server. Change the directory of your wamp to the new directory by using this guidance.

Click on WampServer icon in right side bottom taskbar. Select the Apache menu  -> __httpd-vhosts.conf__ from the Pullup menu box.

![wamp server httpd vhosts conf][image1]

```bash
<VirtualHost *:12>
  ServerName localhost
  ServerAlias localhost
  DocumentRoot "{new directory}"
  <Directory "{new directory}/">
    Options +Indexes +Includes +FollowSymLinks +MultiViews
    AllowOverride All
    Require local
  </Directory>
</VirtualHost>
```

Now run __NGROK__ and put below command:

```bash
ngrok http 12
```

For using this application you should use SSL. So choose a domain which is __https__.

## IIS Server
If you have dedicate server of a VPS, just download this repository and try to deploy it into the server. But if you want to run this project under your local machine try this one.
First open the Visual Studio and follow below structure:
1. Select Tools... Extensions and Updates...
2. Click "Online" and select the "Visual Studio Gallery" along the left-hand side of the window.
3. Type "ngrok" into the search box in the upper right.
4. Click the "Download" button on the extension in the search results.

Currently, usage is super-simple. All you need to do is open a solution with one or more web projects and then choose `Start ngrok Tunnel` from the `Tools` menu.

![NGROK][image3]

This is a brand new extension and would benefit greatly from your feedback and even your code contribution. If you find a bug or would like to request a feature, [open an issue](https://github.com/dprothero/NgrokExtensions/issues). To contribute, fork this repo to your own GitHub account. Then, create a branch on your own fork and perform the work. Push it up to your fork and then submit a Pull Request to this repo. If you are interested in `Github Flow`, you can read [this article](https://guides.github.com/introduction/flow/).

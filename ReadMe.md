[image1]: ./Images/wamp-server-httpd-vhosts.conf.jpg "wamp-server-httpd-vhosts.conf"
[image2]: ./Images/Result.png "Result"

## How to run
Download this repository. Then run your wamp server. Change the directory of your wamp to the new directory by using this guidance.

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

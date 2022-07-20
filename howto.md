# HOWTO

## 1 Generate self signed certificate

* Links
  * <https://stackoverflow.com/a/10176685>
  * <https://dylanbeattie.net/2020/11/18/using-https-with-kestrel.html>
  * <https://serverfault.com/questions/9708/what-is-a-pem-file-and-how-does-it-differ-from-other-openssl-generated-key-file>
  * <https://stackoverflow.com/a/71233481>
* But like this: `openssl req -x509 -newkey rsa:4096 -keyout key.pem -out cert.pem -sha256 -days 365 -nodes -subj '/CN=hittps'`
* Then convert to pfx: `openssl pkcs12 -export -out cert.pfx -inkey key.pem -in cert.pem`
* `.pem` is for use with alpine, to trust the cert
* `.pfx` is for use with kestrel, it's easy to make it use it (because the key is included)

## 2 Use certificate

* From: <https://blog.spacepatroldelta.com/a?ID=01500-5dd8dba9-0a41-4dd1-b263-2f3ab401db06>
* Map `.pfx` into `hittps` (see `compose.yaml`)
* Map `.pem` into `cerenkov` (see `compose.yaml`)
* Trust cert
  * `cp /https/test2/cert.pem /usr/local/share/ca-certificates/`
  * `update-ca-certificates`

# TODO

* Use `--no-cache` for `apk add`
* Trust `Hittps` cert from `Consumer` ✅
* init container to set up certificates ✅
* Make init container recreate invalid certificates (e.g. if expired)
  * Example: `openssl x509 -checkend 0 -in cert.pem`
  * Maybe recreate if there's only a day left
* Make dependent containers trust recreated certificates, if they still trust the old ones

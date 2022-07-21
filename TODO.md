# TODO

* Trust `Hittps` cert from `Consumer` ✅
* init container to set up certificates ✅
* Make init container recreate invalid certificates (e.g. if expired)
* Make dependent containers trust recreated certificates, if they still trust the old ones

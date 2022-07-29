# TODO

* Lint dockerfiles with `hadolint`
  * <https://github.com/hadolint/hadolint>
* Use `shunit2` to unit test init scripts
  * <https://github.com/kward/shunit2>
  * Build base image to base other test images upon
  * Use suitable way to create temp file to buffer stdin input
* Improve init scripts
  * Only use options that make sense for the script
  * Don't use bash if it isn't necessary
  * Better structure
  * Write tests for the scripts
* Use `--no-cache` for `apk add`
  * Cerenkov ✅
  * Certificator ✅
* Trust `Hittps` cert from `Consumer` ✅
* init container to set up certificates ✅
* Make init container recreate invalid certificates (e.g. if expired)
  * Example: `openssl x509 -checkend 0 -in cert.pem`
  * Maybe recreate if there's only a day left
* Make dependent containers trust recreated certificates, if they still trust the old ones

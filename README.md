# Cradle Test Suite

This project is used to run tests on [Cradle](https://github.com/daterre/Cradle) to prepare for packaging and creating a release.

If you have a custom build of Cradle you want to test, follow the following steps:

1. Clone this repo to your local machine.
1. Change the Cradle submodule origin to point to your forked Cradle project. (Make sure you first [build the source code](https://github.com/daterre/Cradle/#source-code) and commit the updated DLLs)
1. Right-click -> Reimport HarloweTests.html and SugarTests.html in their respective folders. This will test that the import process isn't broken.
1. Run integration tests (currently available for Harlowe only):
    1. Open the HarloweTests.unity scene
    1. Open Unity Test Tools -> Integration Test Runner from the menu bar.
    1. Press Run All.

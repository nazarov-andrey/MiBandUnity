#!/bin/bash

/Applications/Unity/Unity.app/Contents/MacOS/Unity \
	-quit \
	-batchMode \
	-projectPath `pwd` \
	-exportPackage Assets/MiBand Assets/Plugins/Android ./MiBand.unitypackage
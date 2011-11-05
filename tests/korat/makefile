all:
	cd korat && ant createJar && cp dist/korat.jar ../ && cd ..
	java -cp korat.jar korat.Korat --visualize --class korat.examples.my.LL --args 5,2,5

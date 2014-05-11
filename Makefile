SOLUTION = Sweet.sln
MAIN_PROJECT = Sweet
TEST_PROJECT = Sweet.Tests
CONFIGURATIONS = Debug Release
VERSION = 0.0.1

.PHONY: all
all: clean build test

.PHONY: clean
clean:
	for configuration in $(CONFIGURATIONS); do \
		xbuild $(SOLUTION) /t:clean /p:Configuration=$$configuration; \
	done

.PHONY: build
build:
	for configuration in $(CONFIGURATIONS); do \
		xbuild $(SOLUTION) /t:build /p:Configuration=$$configuration; \
	done

.PHONY: test
test: build
	./tools/nunit $(TEST_PROJECT)/bin/Debug/$(TEST_PROJECT).dll

.PHONY: nupkg
nupkg: build test
	./tools/nuget pack $(MAIN_PROJECT).nuspec

.PHONY: release
release: nupkg
	./tools/nuget push $(MAIN_PROJECT).$(VERSION).nupkg

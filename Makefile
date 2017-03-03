all: build

SRC	:= hello.fsx

clean:
	rm *.js

build: $(SRC)
	fable $(SRC) --module commonjs


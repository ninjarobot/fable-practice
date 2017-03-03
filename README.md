Learning to use Fable
========

Quick example for getting started with the Fable compiler for Javascript.

Getting Started
--------

Install the compiler
```
npm init
npm install --save-dev fable-compiler
```

Install the core library
```
npm install --save fable-core
```

Build JS using commonjs modules as needed by node.
```
fable hello.fsx --module commonjs
```

Now the generated .js can run in node
```
node hello.js
```

Also, see the Makefile for building and cleaning.
# Roman Numeral Calculator

This kata is meant to be a calculator that is able to return roman numerals. You can put the limit. I would start just calculating till 100 or below and then upgrade to the next limit.
Some basics of the roman numerals. They have some base *numbers* (just to call so) that can be joint following some formulas to get others. There is no 0 in such list!

Roman Numerals Main *Numbers*
* I = 1.
* V = 5.
* X = 10.
* L = 50.
* C = 100.
* D = 500.
* M = 1000.

# About Test Driven Development

TDD is not a testing tool but a **software design tool** that will help us to build solid applications. The basics of TDD can be summarised as follow and this flow is known as "red, green, refactor". There are 3 steps:

1. Write a failing (red) test
1. Make the test pass (green)
1. Refactor your code as needed to keep it clean while keeping the tests passing

To "test drive" this kata, just start for the simplest case and wait that you solution won't run, then fix it until it passes the test and refactor it as soon as you feel that code is duplicated or becomes a mess.

# Debugging tests in VS Code

by [Jag Reehal](https://twitter.com/jagreehal)

This recipe shows how to use the built-in Node Debugger to debug [Mocha](https://mochajs.org/) tests.

## The example

The test folder contains two files that test the lib/calc.js file.

To try the example you'll need to install dependencies by running:

`npm install`

## Configure launch.json File for your test framework

* Click on the Debugging icon in the Activity Bar to bring up the Debug view.
  Then click on the gear icon to configure a launch.json file, selecting **Node** for the environment:

* Replace content of the generated launch.json with the following configurations:

```json
{
  "version": "0.2.0",
  "configurations": [
    {
        "type": "node",
        "request": "launch",
        "name": "Mocha All",
        "program": "${workspaceFolder}/node_modules/mocha/bin/_mocha",
        "args": [
            "--timeout",
            "999999",
            "--colors",
            "${workspaceFolder}/test"
        ],
        "console": "integratedTerminal",
        "internalConsoleOptions": "neverOpen"
    },
    {
        "type": "node",
        "request": "launch",
        "name": "Mocha Current File",
        "program": "${workspaceFolder}/node_modules/mocha/bin/_mocha",
        "args": [
            "--timeout",
            "999999",
            "--colors",
            "${file}"
        ],
        "console": "integratedTerminal",
        "internalConsoleOptions": "neverOpen"
    }
  ]
}
```

If you don't have all of your tests under a common "test" directory, then the following configurations can be used. It will recursively search for all \*.test.js files except for those that are in a node_modules directory.

```json
{
  "version": "0.2.0",
  "configurations": [
    {
        "type": "node",
        "request": "launch",
        "name": "Mocha All",
        "program": "${workspaceFolder}/node_modules/mocha/bin/_mocha",
        "args": [
            "--timeout",
            "999999",
            "--colors",
            "'${workspaceFolder}/{,!(node_modules)/}*/*.test.js'"
        ],
        "console": "integratedTerminal",
        "internalConsoleOptions": "neverOpen"
    },
    {
        "type": "node",
        "request": "launch",
        "name": "Mocha Current File",
        "program": "${workspaceFolder}/node_modules/mocha/bin/_mocha",
        "args": [
            "--timeout",
            "999999",
            "--colors",
            "${file}"
        ],
        "console": "integratedTerminal",
        "internalConsoleOptions": "neverOpen"
    }
  ]
}
```

If you are running mocha will multiple arguments, you may consider creating an opt file that store all these arguments (i.e name it as mocha.opts).

Example file contents with mocha arguments: 

```
--timeout 999999
--colors
--full-trace  
```

Reference the mocha opts file with --opts in configuration as shown below

```json
{
    "version": "0.2.0",
    "configurations": [
        {
            "type": "node",
            "request": "launch",
            "name": "Mocha Test All with Options",
            "program": "${workspaceFolder}/node_modules/mocha/bin/_mocha",
            "args": [
                "--opts", 
                "${workspaceFolder}/support/mocha.opts",
                "${workspaceFolder}/test"
            ],
            "console": "integratedTerminal",
            "internalConsoleOptions": "neverOpen"
        }
    ]
}
```

## Debugging all tests

You can debug all tests by following the steps below:

1. Set a breakpoint in a test file or files

2. Go to the Debug view, select the **'Mocha All'** configuration, then press F5 or click the green play button.

3. Your breakpoint will now be hit

![all](all.gif)

## Debugging the current test

You can debug the test you're editing by following the steps below:

1. Set a breakpoint in a test file

2. Go to the Debug view, select the **'Mocha Current File'** configuration, then press F5 or click the green play button.

3. Your breakpoint will now be hit

![current](current.gif)

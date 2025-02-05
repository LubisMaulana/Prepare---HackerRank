'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}

/*
 * Complete the 'pickingNumbers' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts INTEGER_ARRAY a as parameter.
 */

function pickingNumbers(a) {
    // Write your code here
    let min = Math.min(...a) + 1;
    const arr = {};

    while (a.length > 0){
        for (let i = 0; i < a.length;){ 
            if (a[i] <= min){
                arr[min] = arr[min] ? arr[min] + 1 : 1
                a.splice(i, 1)
            }else{
                i++;
            }
        }
        min = Math.min(...a) + 1;
    }

    return Math.max(...Object.values(arr));
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine().trim(), 10);

    const a = readLine().replace(/\s+$/g, '').split(' ').map(aTemp => parseInt(aTemp, 10));

    const result = pickingNumbers(a);

    ws.write(result + '\n');

    ws.end();
}

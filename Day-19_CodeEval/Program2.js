input_array = getProgramInputs();

var character = input_array[0];
var count = Number(input_array[1]);

function repeatCharacter(character, count) {
    // Add your code below this line
    let res="";
    for(let i=0;i<count;i++) {
        res=res+character;
    }
    return res;
}

var output = repeatCharacter(character, count);
console.log(output);
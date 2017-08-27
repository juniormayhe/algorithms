//const array_length;
const _heapRoot = (array_length, input, i) =>{
    const left = 2 * i + 1;
    const right = 2 * i + 2;
    let max = i;
	
	
    if (left < array_length && input[left] > input[max])
        max = left;

    if (right < array_length && input[right] > input[max])
        max = right;

    if (max != i) {
        _swap(input, i, max);
        _heapRoot(array_length, input, max);
    }
}

function _swap(input, index_A, index_B) {
    const temp = input[index_A];

    input[index_A] = input[index_B];
    input[index_B] = temp;
}

//input is an array
function heapSort(input) {
    
    let array_length = input.length;

    for (var i = Math.floor(array_length / 2); i >= 0; i -= 1)
        _heapRoot(array_length, input, i);

    for (i = input.length - 1; i > 0; i--) {
        _swap(input, 0, i);
        array_length--;
        _heapRoot(array_length, input, 0);
    }
	
	console.log(input); 
	return input;
}

//var arr = [3, 0, 2, 5, -1, 4, 1];
//heapSort(arr);

var node = {
	left: undefined,
	right: undefined,
	value:null
}
var inOrderValues = [];
var preOrderValues = [];
var postOrderValues = [];
var reversedValues = [];
var descendingValues = [];

function insert(tree, value){

	//tree is empty?
	if (tree && tree.value)
	{
		//if value is smaller than current tree value
		if (value < tree.value)
			insert(tree.left, value);//put value on the left side of tree
		else
			insert(tree.right, value);//put value on the right side of tree*/
	}
	else{
		//init root
		tree.value = value;
		tree.left =  {};
		tree.right = {};
	}
}

function printReverseTree(root) {
    if (root == null)
        return;

    var temp = root.right;
    root.right = root.left;
    root.left = temp;

    printReverseTree(root.left);
    printReverseTree(root.right);
    
    if (root.value){
    	console.log("  value:"+ root.value);
    	reversedValues.push(root.value);
    }
}

function printInOrder(root){
	if (root.value == null)  return;
	printInOrder(root.left);
	console.log("  value: " + root.value);
	inOrderValues.push(root.value);
	printInOrder(root.right);

}

function printDescending(root)
{
    if(root.value == null) return;
    printDescending(root.right);
    console.log("  value: "+ root.value);
    descendingValues.push(root.value);
    printDescending(root.left);
}

function printPreOrder(root){
	if (!root.value) return;
	console.log("  value: " + root.value);
	preOrderValues.push(root.value);
	root.left && printPreOrder(root.left);
	root.right && printPreOrder(root.right);

}

function printPostOrder(root){
	if (!root.value) return;
	root.left && printPostOrder(root.left);
	root.right && printPostOrder(root.right);
	console.log("  value: "+root.value);
	postOrderValues.push(root.value);
}



function run(){
	console.log("Running");
	
	inOrderValues = [];
	preOrderValues = [];
	postOrderValues = [];

	var txtValues = document.getElementById('values');
	if (!txtValues.value){
		alert("Add comma separated values");
		txtValues.focus();
		return;
	}

	let values = txtValues.value.split(',');
	console.log(values);
	values.forEach(function(value, index, array){
		insert(node, parseInt(value));

	});
	document.getElementById("tree").innerText = JSON.stringify(node);
	console.log(node);

	console.log("printInOrder");
	printInOrder(node);

	console.log("printDescending");
	printDescending(node);

	console.log("printInPreOrder");
	printPreOrder(node);

	console.log("printInPostOrder");
	printPostOrder(node);

	console.log("printReverseTree");
	printReverseTree(node);

	
	document.getElementById("preOrder").innerText = JSON.stringify(preOrderValues);
	document.getElementById("reversed").innerText = JSON.stringify(reversedValues);
	document.getElementById("postOrder").innerText = JSON.stringify(postOrderValues);
	document.getElementById("inOrder").innerText = JSON.stringify(inOrderValues);
	document.getElementById("descending").innerText = JSON.stringify(descendingValues);


 	node = {
		left: undefined,
		right: undefined,
		value:null}
}


/*
insert(t, 5);
insert(t, 10);
insert(t, 12);
insert(t, 3);
insert(t, 4);
insert(t, 1);


function printInOrder(root){
	if (root.value){
		printInOrder(root.left);
		console.log("  value: " + root.value);
		printInOrder(root.right);
	}
}



console.log("printPreOrder");
printPreOrder(t);


console.log("printPosOrder");
printPosOrder(t);

function searchInTree(root, value){
	if (root == null) return null;
	if (value === root.value) return "Found:" + root.value;
	//check left tree for smaller values
	if (value < root.value) 
		return searchInTree(root.left, value);
	else
		return searchInTree(root.right, value);
}
console.log(searchInTree(t, 10));
***/






/*class Node {

	constructor(){
		this.left = null;
		this.right = null;
	}

	setValue(value){
		this.value = value;
	}

	getValue(){
		return this.value;
	}

}

function insert(root, value){
	if (!root.hasOwnProperty('value'))
		//if there is no value, set the root value
		return root.setValue(value);
	else
	{
		while (true) {
			//left side of tree
			if (value <= root.value)
			{
				//if there is no left element
				if (!root.left){
					//insert smaller value as new node on the left of root element
					root.left = new Node();
					return root.left.setValue(value);
				}
				else {
					//skip down to the next node on the left
					root = root.left;
				}

			}
			else
			{//right side of tree
				
				//if there is no right node
				if (!root.right){
					//insert greater value as new node on the right of root element
					root.right = new Node();
					return root.right.setValue(value);
				}
				else {
					//skip down to the next node on the right
					root = root.right;
				}

			}//if

		}//while

	}
}

//test binary tree
var root = new Node();

insert(root, 5);
insert(root, 10);
insert(root, 12);

insert(root, 3);
insert(root, 4);
insert(root, 1);

//console.log(root);

function printInOrder(root){
	if (root){
		printInOrder(root.left);
		console.log(root.getValue());
		printInOrder(root.right);
	}
}
printInOrder(root);


function searchInTree(root, value){
	
	console.log("step:" + step++);
	if (root == null) return null;
	if (value == root.value) return root;
	//check left tree for smaller values
	if (value < root.value) 
		return searchInTree(root.left, value);
	else
		return searchInTree(root.right, value);
}

var step = 0;
console.log(searchInTree(root, 4));
var step = 0;
console.log(searchInTree(root, 12));
var step = 0;
console.log(searchInTree(root, 5));
var step = 0;
console.log(searchInTree(root, 3));*/
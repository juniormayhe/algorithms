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

	//tree has value?
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
zeon.accessTree = (function() {
    var options =
    {
        fileId : null,
        containerId: null
    };

    var nodes = [];
    var chart;

    function createTree(model) {     
        var config = {
            container: options.containerId
        };
        nodes = [];
        nodes.push(config);
        addNodes(model, null);

        chart = new Treant(nodes);
    }

    function addNodes(model, parent) {
        var currentNode;
        if (parent) {
            if (model.Gate) {
                currentNode = {
                    parent: parent,
                    text: { name: model.Gate.Name },
                    HTMLclass: "treeGate"
                };
                nodes.push(currentNode);
            } else {
                currentNode = {
                    parent: parent,
                    text: { name: model.FileAttribute.AttributeTypeName + " : " + model.FileAttribute.Value },
                    HTMLclass: "treeAttribute"
                };
                nodes.push(currentNode);
            }
        } else {
            if (model.Gate) {
                currentNode = {
                    text: { name: model.Gate.Name },
                    HTMLclass: "treeGate"
                };
                nodes.push(currentNode);
            } else {
                currentNode = {
                    text: { name: model.FileAttribute.AttributeTypeName + " : " + model.FileAttribute.Value },
                    HTMLclass: "treeAttribute"
                };
                nodes.push(currentNode);
            }
        }

        model.Children.forEach(function (node) {
            addNodes(node, currentNode);
        });
    }

    function getAccessTree() {
        $.ajax({
            type: "GET",
            dataType : "json",
            url: "./FileDetails/GetAccessTree",
            data: {
                fileId: options.fileId
            },
            success: function (result) {
                console.log(result);
                createTree(result);
            }
        });
    }

    return {
        init: function(opt) {
            options = opt || options;
            getAccessTree();
        }
    }
}());
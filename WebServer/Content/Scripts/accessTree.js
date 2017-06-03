zeon.accessTree = (function() {
    var options =
    {
        dialogId: null,
        addRootBtnId: null,
        addGateBtnId: null,
        addAttributeBtnId: null,
        txtRootId: null,
        txtGateId: null,
        txtAttributeTypeId: null,
        txtAttributeValueId: null,
        fileId : null,
        containerId: null
    };

    var nodes = [];
    var chart;
    var selectedNodeId;

    function createTree(model) {     
        var config = {
            container: options.containerId,
            connectors: {
                type: "step"
            },
            node: {
            },
            animation: {
                nodeAnimation: "linear",
                nodeSpeed: 300,
                connectorsSpeed: 300,
                connectorsAnimation: "linear"
            }
        };
        nodes = [];
        nodes.push(config);
        addNodes(model, null);

        chart = new Treant(nodes, null, $);

        addNodeBindings();
    }

    function addNodeBindings() {
        var treeNodes = $(options.containerId + ">.node");
        treeNodes.each(function () {
            var accessTreeId = this.id.split("-")[1];
            $(this).on("click",
                function() {
                    selectedNodeId = accessTreeId;
                    openDialog();
                });
        });
    }

    function addNodes(model, parent) {
        var currentNode;
        if (parent) {
            if (model.Gate) {
                currentNode = {
                    parent: parent,
                    text: { name: model.Gate.Name },
                    HTMLclass: "treeGate",
                    HTMLid: 'nodeId-' + model.AccessTreeId
                };
                nodes.push(currentNode);
            } else {
                currentNode = {
                    parent: parent,
                    text: { name: model.FileAttribute.AttributeTypeName + " : " + model.FileAttribute.Value },
                    HTMLclass: "treeAttribute",
                    HTMLid: 'nodeId-' + model.AccessTreeId
                };
                nodes.push(currentNode);
            }
        } else {
            if (model.Gate) {
                currentNode = {
                    text: { name: model.Gate.Name },
                    HTMLclass: "treeGate",
                    HTMLid: 'nodeId-' + model.AccessTreeId
                };
                nodes.push(currentNode);
            } else {
                currentNode = {
                    Id: model.AccessTreeId,
                    text: { name: model.FileAttribute.AttributeTypeName + " : " + model.FileAttribute.Value },
                    HTMLclass: "treeAttribute",
                    HTMLid: 'nodeId-' + model.AccessTreeId
                };
                nodes.push(currentNode);
            }
        }

        model.Children.forEach(function (node) {
            addNodes(node, currentNode);
        });
    }

    function getAccessTree() {
        if (options.fileId === "0") {
            return;
        }
        $.ajax({
            type: "GET",
            dataType : "json",
            url: "./FileDetails/GetAccessTree",
            data: {
                fileId: options.fileId
            },
            success: function (result) {
                if (result) {
                    createTree(result);
                    hideAddRootSection();
                }
            },
            error: function () {
                showAddRootSection();
            }
        });
    }

    function addRoot(parentId, gateId) {
        $.ajax({
            type: "GET",
            dataType: "json",
            url: "./FileDetails/AddRoot",
            data: {
                fileId: options.fileId,
                parentId: parentId,
                gateId: gateId
            },
            success: function (result) {
                createTree(result);
                hideAddRootSection();
            }
        });
    }

    function addGate(parentId, gateId) {
        $.ajax({
            type: "GET",
            dataType: "json",
            url: "./FileDetails/AddGate",
            data: {
                fileId: options.fileId,
                parentId: parentId,
                gateId: gateId
            },
            success: function (result) {
                createTree(result);
                closeDialog();
                clearFields();
            }
        });
    }

    function addAttribute(parentId, attributeTypeId, value) {
        $.ajax({
            type: "GET",
            dataType: "json",
            url: "./FileDetails/AddAttribute",
            data: {
                fileId: options.fileId,
                parentId: parentId,
                attributeTypeId: attributeTypeId,
                value : value
            },
            success: function (result) {
                createTree(result);
                closeDialog();
                clearFields();
            }
        });
    }

    function addBindings() {
        $(options.addRootBtnId).on("click", function() {
            var gateId = $(options.txtRootId).val();
            addRoot(selectedNodeId, gateId);
        });
        $(options.addGateBtnId).on("click", function () {
            var gateId = $(options.txtGateId).val();
            addGate(selectedNodeId, gateId);
        });
        $(options.addAttributeBtnId).on("click", function () {
            var attributeTypeId = $(options.txtAttributeTypeId).val();
            var attributeValue = $(options.txtAttributeValueId).val();
            addAttribute(selectedNodeId, attributeTypeId, attributeValue);
        });
    }

    function openDialog() {
        $(options.dialogId).dialog();
        $(options.dialogId).dialog('open');
    }

    function closeDialog() {
        $(options.dialogId).dialog('close');
    }

    function showAddRootSection() {
        $('#addRootSection').show();
    }

    function hideAddRootSection() {
        $('#addRootSection').hide();
    }

    function setViewStateOfControls() {
        if (nodes.count === 1) {
            hideAddRootSection();
        }
    }

    function clearFields() {
        $(options.txtAttributeValueId).val("");
        $(options.txtAttributeTypeId).prop('selectedIndex', 0);
        $(options.txtGateId).prop('selectedIndex', 0);
    }

    return {
        init: function(opt) {
            options = opt || options;
            getAccessTree();
            addBindings();
        }
    }
}());
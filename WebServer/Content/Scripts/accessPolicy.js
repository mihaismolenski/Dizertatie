zeon.accessPolicy = (function() {
    var options =
    {
        gatesContainer: null,
        attributesContainer: null,
        inputId: null,
        containerId: null
    };

    function addBindings() {

        $(options.gatesContainer + '>.gate-control').each(function () {
            $(this).on("click",
                function() {
                    $(options.containerId).append($(this).clone());
                });
        });

        $(options.attributesContainer + '>.attribute-control').each(function () {
            $(this).on("click",
                function () {
                    var value = prompt("Set value for the attribute");
                    $(options.containerId).append($(this).clone());
                    $(options.containerId).append("=<span class='attribute-value-control'>"+ value + "</span>");
                });
        });
    }

    return {
        init: function(opt) {
            options = opt || options;
            addBindings();
        }
    }
}());
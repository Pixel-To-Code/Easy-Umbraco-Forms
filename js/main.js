var Main = {
    run: function () {
        validateForm.init();
    }
};


var validateForm = {

    init: function () {
        
        if (rules)
        {
            // for testing
            //jQuery.validator.setDefaults({
            //    debug: true,
            //    success: "valid"
            //});

            // add the regex method to check regex's in validation 

            $.validator.addMethod(
                "regex",
                function (value, element, regexp) {
                    var re = new RegExp(regexp, "gi");
                    return this.optional(element) || re.test(value);
                },
                "Please check your input."
            );

            // validate the form

            $("form").validate({
                rules: rules,
                onfocusout: function (element) {
                    this.element(element);
                },
                highlight: function (element) {
                    $(element).closest('.form-group').removeClass('has-success').addClass('has-error');
                },
                unhighlight: function (element) {
                    $(element).closest('.form-group').removeClass('has-error').addClass('has-success');
                }
            });
        
        }
    }

};


$(document).ready(function () {
    Main.run();
});



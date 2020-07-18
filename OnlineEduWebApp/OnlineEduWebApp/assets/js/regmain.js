$(function () {

    //$("#signup").prop("disabled", true);
    $(document).on("change", ".is-agree", function () {
        var b = isChecked();
        if (b) {
            $(".check-box-error-message").hide()
        }
        else {
            $(".check-box-error-message").show()
           
        }
    })
   
    function isChecked() {
        if ($(".is-agree").is(":unchecked")) {
          
            return false;
        }
        else {
       
            return true;
        }
    }
    
     //$(document).on("click", "#signup", function () {
    //    if ($("#agree-term").is(":unchecked")) {
    //        $(".agree-term-error span").addClass("show-error");
    //    }
    //    else {
    //        $("#signup").prop("disabled", false);
    //    }
    //})

   
})
$('#form-btn').on('click', function(event){
    event.preventDefault();    
    var $inputs = $('form :input');
    var values = {}
        if($('input').val() != ""){
            $inputs.each(function(){
            values[this.name] = $(this).val();
        });
        $('table').append("<tr><td>"+values.name+"</td><td>"+values.age+"</td><td>"+values.email+"</td><td>"+values.city+"</td><td><span class='delete'><i class='fas fa-trash-alt'></i></span></td></tr>");
        $('input').val("");
        }
    else{
        alert('All field must be full')
    }
});
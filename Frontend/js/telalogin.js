
function sendInformations(emailAddress, password){
    
    const data ={
        emailAddress: emailAddress,
        password: password,
    }

    console.log(data)
    
    fetch("https://localhost:7200/usuariologin",{
        method:"POST",
        mode:"cors",
        headers:{
            'Content-Type':'application/json'
        },
        body: JSON.stringify(data)
    }).then((response) =>
        response.json()).then((result) =>{
            Swal.fire(
                'Sucesso!',
                'Login executado com sucesso!',
                'success'
            )
            
          setTimeout(function() {
            window.location.href = "http://127.0.0.1:5500/Frontend/tela-contrate.html";
          }, 5000);
            
            })
    .catch((error) =>{
        Swal.fire(
            'Erro!',
            'Erro ao fazer o login dos dados',
            'error'
        )
    })
}



function login(){
    let emailAddress = document.getElementById("email").value
    let password = document.getElementById("password").value

    let errors = []
    
    if(emailAddress.length <= 5 && emailAddress.indexOf("@") === -1){
        errors.push("Digite um e-mail válido!")   
    }
    
    if(password.length < 8){
        errors.push("Digite uma senha com mais de 8 caracteres!")
    }

    if(errors.length == 0){
    
        sendInformations(emailAddress, password)
    }
    else{

        Swal.fire(
            'Erro!',
            errors.join("<br><br>"),
            'error'
        )
    }

    return false

}

function enviar(email, senha){
    
    const data ={
        Email: email,
        Senha: senha,
    }
    
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
    let email = document.getElementById("email").value
    let senha = document.getElementById("password").value

    let erros = []
    
    if(email.length <= 0){
        erros.push("Digite um e-mail válido!")   
    }
    
    if(senha.length < 8){
        erros.push("Digite uma senha com mais de 8 caracteres!")
    }

    if(erros.length == 0){
    
        enviar(email, senha)
    }
    else{

        Swal.fire(
            'Erro!',
             erros.join("<br><br>"),
            'error'
        )
    }

    return false

}
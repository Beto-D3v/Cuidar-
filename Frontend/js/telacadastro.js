function sendInformations(userInput){
    
  const data ={
      name: userInput[0],
      emailaddress: userInput[1],
      cpf: userInput[2],
      birthDate:userInput[3],
      phone:userInput[4],
      state:userInput[5],
      city:userInput[6],
      profession:userInput[7],
      dayValue:userInput[8],
      nightValue:userInput[9],
      professionalNumber:userInput[10],
      presentation:userInput[11],
      password:userInput[12],
  }
  
  fetch("https://localhost:7200/cuidadores",{
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
              'Cadastro executado com sucesso! Nossa Equipe irá avaliar suas informações!',
              'success'
          )
          setTimeout(function() {
            window.location.href = "http://127.0.0.1:5500/Frontend/telalogin.html";
          }, 5000);

          })
  .catch((error) =>{
      Swal.fire(
          'Erro!',
          'Erro ao fazer o cadastro dos dados!',
          'error'
      )
  })
}


function setAction() {
  
  let name = document.getElementById('name').value;
  let emailaddress = document.getElementById('emailaddress').value;
  let cpf = document.getElementById('cpf').value;
  let birthDate = document.getElementById('birthDate').value;
  let phone = document.getElementById('phone').value;
  let state = document.getElementById('state').value;
  let city = document.getElementById('city').value;
  let profession = document.getElementById('profession').value;
  let dayValue = document.getElementById('dayValue').value;
  let nightValue = document.getElementById('nightValue').value;
  let professionalNumber = document.getElementById('professionalNumber').value;
  let presentation = document.getElementById('presentation').value;
  let password = document.getElementById('password').value;
  let confirmPassword = document.getElementById('confirmPassword').value;

  let dateSplit = birthDate.split("-")
  let year = dateSplit[0]
  let month = dateSplit[1]
  let day = dateSplit[2]

  let nDate = new Date()

  const userInput = [];

  userInput.push(
    name,
    emailaddress,
    cpf,
    birthDate,
    phone,
    state,
    city,
    profession,
    dayValue,
    nightValue,
    professionalNumber,
    presentation,
    password);

  let errors = []

  if(name.length <= 5 && name.indexOf(" ") === -1){
    errors.push("Cadastre o nome completo!")
  }

  if(emailaddress.length <= 5 && emailaddress.indexOf("@") === -1){
    errors.push("Preencha um e-mail válido!")
  }

  if(cpf.length < 11){
    errors.push("O CPF deve ter pelo menos 11 caracteres!")
  }

  if(parseInt(year) > nDate.getFullYear()){
    errors.push("Digite uma data válida!")
  }

  if(nDate.getFullYear() - parseInt(year) < 18){
    errors.push("O cuidador precisa ser maior de 18 anos!")
  }

  if(nDate.getFullYear() - parseInt(year) == 18){
    
    if(nDate.getMonth() + 1 > parseInt(month)){
      errors.push("O cuidador precisa ser maior de 18 anos!")
    }

    if(nDate.getMonth() + 1 == parseInt(month)){

      if(nDate.getDay() < parseInt(day)){
        errors.push("O cuidador precisa ser maior de 18 anos!")
      }
    }

  }

  if(profession.length == 0){
    errors.push("O preenchimento da área de atuação é obrigatória!")
  }

  if(dayValue <= 0 || nightValue <= 0){
    errors.push("Preencha o valor da hora corretamente!")
  }

  if(professionalNumber.length == 0){
    errors.push("O preenchimento do número profissional é obrigatório!")
  }

  if(password.length < 8){
    errors.push("Preencha uma senha válida, acima de 8 caracteres!")
  }

  if(password != confirmPassword){
    errors.push("As senhas devem ser iguais para a validação!")
  }

  if(errors.length == 0){
    sendInformations(userInput)
  }

  else{

    Swal.fire(
        'Erro!',
        errors.join("<br><br>"),
        'error'
    )
}

return false;

}
function setAction(form) {
  form.action = "cadastro.html";
  
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
  
  console.log(userInput);

  return false;
}
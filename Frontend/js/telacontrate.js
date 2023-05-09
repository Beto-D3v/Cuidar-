function searchList(){
    fetch("https://localhost:7200/cuidadores",{
      method:"GET",
      mode:"cors",
      headers:{
          'Content-Type':'application/json'
      }
  }).then((response) =>
      response.json()).then((result) =>{
        console.log(result)
        loadList(result)
       })
  .catch((error) =>{
      Swal.fire(
          'Erro!',
          'Erro ao apresentar os dados!',
          'error'
      )
  })
}

function loadList(cuidadores){

    let tabela = document.querySelector("#tabela tbody")

    
    for(let cuidador of cuidadores){
        
        let splitDate = cuidador.birthDate.split("-")
        let year = splitDate[0]
        let actualDate =  new Date()
        let age = actualDate.getFullYear() - year
        
        let linha = 
        `
        <tr>
            <td>${cuidador.name}</td>
            <td>${age} anos</td>
            <td>${cuidador.phone}</td>
            <td>${cuidador.city}</td>
            <td>${cuidador.profession}</td>
            <td>R$${cuidador.dayValue},00</td>
            <td>R$${cuidador.nightValue},00</td>
            <td>${cuidador.presentation}</td>
        </tr>
        `

        let tr = document.createElement("tr")
        tr.innerHTML = linha
        tabela.appendChild(tr)
    }

}
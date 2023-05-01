# Cuidar+
Projeto Senac 

# Sobre o projeto 

Link de uso do projeto :

O projeto Cuidar+ é uma aplicação [*], que foi desenvolvido pensando em facilitar a gestão e monitoramento dos pacientes idosos que necessitam do acompanhamento hospitalar, ela permite que médicos, enfermeiros e outros profissionais de saúde possam se cadastrar e oferecer seus serviços de maneira integral, proporcionando um atendimento eficiente e seguro aos pacientes. 

## Disposição



[Imagens telas]



## Padrão arquitetural
A aplicação Cuidar+ foi projetada através da arquitetura padrão MVC (Model View Controller). Por meio deste padrão de arquitetura, o projeto fica separado em camadas (camadas lógicas), promovendo a separação do código em partes distintas, dependendo da separação de responsabilidade dos componentes.
Neste padrão, o Model do projeto, conterá a parte da lógica de negócios, a view irá apresentar nas telas, como informações para o usuário. E por fim, temos a intermediação das camadas que serão executadas pelo controlador.

# Tecnologias utilizadas
## Processo interno
•	C#

•	Entity Framework

•	[...]

## Front-end
•	[...]

•	[...]

•	[...]

## Banco de dados relacional
• Microsoft SQL
# Executando o projeto
## Front-end

[              ]

## Processo interno
Dependências para rodar o projeto: [...]

Banco de dados: [...]

Iniciando o projeto: [...]

# Testando a aplicação
## Tela de boas	 vindas
Na primeira página, há duas opções de caminho para o usuário: clicar no botão de cadastro ou para a tela de Login. Caso ele não possua cadastro, ele poderá clicar em “Criar cadastro”. Caso ele já possua seus dados cadastrais, ele poderá efetuar o login.
## Tela de cadastro
Nesta tela, o usuário deverá digitar seus dados e preencher todos os campos obrigatórios (nome, e-mail, CPF, Idade, Telefone, Estado, Cidade, Área de atuação, Valor hora e número do documento Coren.
Obs. importantes: o CPF deve ter 11 caracteres; a uf deve possuir 2 caracteres; o [*cep deve possuir 8 caracteres *]; A senha deve ter 6 caracteres, no mínimo; Senha e confirmação de senha devem ser iguais.
Ao realizar o cadastro, as informações do usuário serão armazenadas em um banco de dados relacional.  
## Tela de login
Ao receber a confirmação de análise dos dados cadastrais, o usuário poderá realizar o login. Lembrando que ambos os campos dessa tela são obrigatórios e que a senha deve ter no mínimo 6 caracteres.
Caso as informações estejam de acordo, o usuário será redirecionado [*para a tela principal ela fica aguardara o contato de futuros pacientes*].	
## Resultados
[              ]

# Autores:
- Amanda Barreto Rocha
- Lucas Pereira Costa
- Lúcio Dos Santos Júnior
- Priscila Cristina de Melo
- Rafaela Eduarda Teixeira Silva
- Roberto Macedo

# Desafio Tryitter

Este é o projeto de conclusão da aceleração de C# realizado na Trybe em parceria com a empresa TMB Educação.<br>
Nele, criamos uma aplicação simples na qual um estudante usuário pode se cadastrar e criar post acerca do seu desenvolvimento na Trybe.<br>
A aplicação é full stack, ou seja possui front end, back end e banco de dados, todos hospedados na Microsoft Azure.<br>
O back end possui testes de integração com cobertura de aproximadamente 46%.<br>

## Desenvolvido por:

Carlos Alberto Souza Lima Júnior.<br>
github: https://github.com/lima-bigs<br><br>
Gustavo Fernandes.<br>
github: https://github.com/GustavoSFer<br>

## Front End

Desenvolvido em Javascript com React.<br>
Pode ser acessado em:<br>

https://tryitter-web.azurewebsites.net/<br>

Para iniciar a aplicação localmente, à partir do diretório /Front-end/tryitter, execute os seguintes comandos:<br>
- npm install;<br>
- npm start;<br>
- abrir o browser e acessar: http://localhost:3000/<br>

## Back End

Desenvolvido com C Sharp.<br>
Sua documentação está disponível no link abaixo com o uso do Swagger:<br>

https://tryitter-app.azurewebsites.net/swagger/index.html<br>

Com exceção das rotas de login e criação de usuário, que são de acesso anônimo permitido, as demais rotas exigem o token de  autenticação criado com JWT.<br>
Os testes de integração foram criados utilizando Xunit e Fluent Assertions e cobertem 46% do back end.<br>

Para iniciar a aplicação localmente, à partir do diretório /Back-end/tryitter-back-end, execute os seguintes comandos:<br>
- dotnet run;<br>
- abrir o browser e acessar: https://localhost: {coloque o numero da porta que aparece no terminal após o comando acima}/swagger/index.html<br>

## Banco de Dados

Desenvolvido em Sql Server diretamente dentro da plataforma Microsoft Azure.

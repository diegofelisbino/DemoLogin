# DemoLogin

Aplicação dotnet com um exemplo de login, que fornece um token jwt, para que seja validado a Authenticação e  Authorização.

A aplicação contém 3 endpoints:

POST => /v1/contas/user
GET  => /v1/contas/admin
GET  => /v1/contas/user

## Como utilizar

Para realizar login com usuário com perfil "admin", realize o login com as seguintes credencias:

email: diego@dominio.com
senha: 123456

Um usuário com perfil "admin", tem permissão para realizar requisição em ambas as rotas.

Para realizar login com o usuário com perfil "user", utilize:

email: joao@dominio.com
senha: 111111

Um usuário com perfil "user", tem permissão para realizar requisição somente na rota /user.

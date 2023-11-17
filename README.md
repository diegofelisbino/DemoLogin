# DemoLogin

A aplicação dotnet com um exemplo de login com a Authorização e Authenticação.

A aplicação contém 3 endpoints:

POST => /v1/contas/user
GET  => /v1/contas/admin
GET  => /v1/contas/user

Um usuário com perfil "admin", tem permissão para realizar requisição em ambas as rotas.

Um usuário com perfil "user", só tem permissão para realizar requisição na rota /user.

## Setup

Para realizar login com usuário com perfil "admin", utilize:

email: diego@dominio.com
senha: 123456

Para realizar login com o usuário com perfil "user", utilize:

email: joao@dominio.com
senha: 111111

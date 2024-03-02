# Booking
 
Aplicação ASP.NET Core 6 com Angular 17.2.3
Este repositório contém uma aplicação desenvolvida utilizando ASP.NET Core 6 no backend e Angular 17.2.3 no frontend. 
Siga as instruções abaixo para configurar e executar a aplicação em seu ambiente local.

Pré-requisitos
Antes de executar a aplicação, certifique-se de ter as seguintes ferramentas instaladas em seu sistema:

.NET SDK 6
Node.js (preferencialmente versão LTS)
Angular CLI: Você pode instalar o Angular CLI globalmente utilizando o seguinte comando:
css
Copy code
npm install -g @angular/cli@17.2.3
Configuração
Clone este repositório em seu ambiente local:

bash
Copy code
git clone https://github.com/seu-usuario/nome-do-repositorio.git
Navegue até o diretório do frontend:

bash
Copy code
cd nome-do-repositorio/frontend
Instale as dependências do frontend:

Copy code
npm install
Navegue até o diretório do backend:

bash
Copy code
cd ../backend
Restaure os pacotes do NuGet:

Copy code
dotnet restore
Executando a Aplicação
Após concluir a configuração, você pode iniciar a aplicação. Certifique-se de seguir os passos na ordem indicada abaixo:

Inicie o backend:

arduino
Copy code
dotnet run
Isso iniciará o servidor ASP.NET Core.

Em uma nova janela do terminal, navegue até o diretório do frontend:

bash
Copy code
cd nome-do-repositorio/frontend
Inicie o servidor de desenvolvimento do Angular:

Copy code
ng serve
Abra seu navegador e acesse http://localhost:4200/ para visualizar a aplicação em execução.

Contribuição
Sinta-se à vontade para contribuir com melhorias para esta aplicação através de pull requests. Se você encontrar problemas ou tiver sugestões, abra uma issue neste repositório.

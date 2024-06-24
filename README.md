
# Authentication & Authorization

Aplicação MVC em .NetCore 5 para estudo dos processos de Autenticação e Autorização em Jwt
- .Net Core 5
- MVC


## Rodando localmente

1. Clone o projeto

```bash
  git clone https://github.com/WilliamAbelo/FCWebApplication.git
```
2. Rodando a aplicação pelo prompt
    - ***certifique-se de estar na pasta do projeto***
    - Restaures os pacotes Nuget
        ```bash
        dotnet restore
        ```
    - Build o projeto
        ```bash
            dotnet restore
        ```
    - Rode o projeto
        ```bash
            dotnet run --project ApiAuthentication
        ```
    [Dotnet Restore](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-restore)

    [Dotnet Build](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-build)
    
    [Dotnet run](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-run)

3. Rodando a aplicação pelo Visual Studio

![open project](https://learn.microsoft.com/fr-fr/visualstudio/ide/media/vs-2019/open-local-project-from-cloned-repo.png?view=vs-2017&viewFallbackFrom=vs-2022)

    3. Apos aberto o projeto, rode com o iis express

![run project](https://user-images.githubusercontent.com/1798510/68414453-81092500-0190-11ea-8564-918bd89f0da5.png)

> [!WARNING]
> Certifique-se que estaja na pagina /swagger/index.html. apos rodar o projeto.

## Funcionalidades

- Login com geração de token JWT
- Autenticação do usuario Logado
- Autorização do usuario Logado definido por diferentes Roles.


## Autores

- [@WilliamAbelo](https://github.com/WilliamAbelo)

# Base de dados:
#### Crie a estrutura do banco de dados usando o arquivo estrutura.sql na pasta do projeto.

# Comandos iniciais:
``` bash
    ls estrutura
```

``` bash
    mkdir api-desafio21dias
    cd api-desafio21dias
    dotnet run webapi
```

### gerei o conteúdo para ignorar itens como (Windows, Linux, MacOS, DotnetCore, VisualStudioCore) no link https://www.toptal.com/developers/gitignore
``` bash
    code .gitignore 
```

# Comandos git:
- Criei o repositório e rodei os comandos:
``` bash
    git init
    git add .
    git commit -m "Iniciando projeto"
    git remote add origin git@github.com:alejandro-espejo/api-desafio21dias.git
    git branch -M main
    git push -u origin main
```

# Componentes instalados:
``` bash
    dotnet add package Microsoft.EntityFrameworkCore --version 8.0.1
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.1
    dotnet add package EntityFrameworkPaginateCore --version 2.1.0
```

# Um pouco sobre API REST
GET - Buscar Informações
POST - Cadastrar informações

Curso do torne-se um programador.
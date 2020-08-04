# graphql-inspector-dotnet

Exemplo usando graphql-inspector com api GraphQL em .net core 3.1

O GraphQL Inspector trabalha com schemas e docs do GraphQL, utilizado principalmente para identificar alterações entre versões de schemas e docs.

## Dependências

Instalação do gerenciador de pacotes [npm][npm-url].
    
## Instalação

Para comparar os schemas deste exemplo, primeiramente será necessário baixar o repositório e instalar o graphql-inspector conforme os passos a seguir:

Baixando o repositório localmente
```cmd
git clone https://github.com/mathiasosmar1/graphql-inspector-dotnet.git
```

Instalando graphql-inspector cli
```cmd
npm install --global @graphql-inspector/cli graphql
```

### Gerar schema de uma api GraphQl

Existem várias maneiras de obter o schema da sua api GraphQL, nesse exemplo será demonstrado como exportar o schema da api *Graphql.Api* atráves do *graphql-inspector cli*.

Para obter o schema do GraphQL é necessário que a api esteja executando. Para isso siga os passos abaixo:

```cmd
cd graphql-inspector-dotnet

dotnet build

dotnet run --project Graphql.Api\Graphql.Api.csproj
```

Depois de iniciar a api, vamos abrir outro terminal para poder executar os comandos do *graphql-inspector cli*. A execução dos comandos devem ser a partir da pasta *graphql-inspector-dotnet*.

```cmd
graphql-inspector introspect http://localhost:5000/graphql --write schemas/new_schema.graphql
```

Depois de executar o comando, será gerado um novo arquivo *new_schema.graphql* dentro da pasta *schemas*, que podemos usar para realizar comparações a seguir.

### Executar comparação entre schemas

Após a execução do passo anterior é possível encontrar 3 arquivos *.graphql* dentro da pasta *schemas*, todos gerados através do *graphql-inspector cli*. Bom, agora vamos realizar a comparação desses arquivos, com intuito de identificar *breaking changes* e alterações entre os schemas.

Há várias maneiras de comparar schemas de uma api, abaixo serão demonstradas algumas formas de comparação:

Antes de iniciarmos as comparações, será necessário acessar a pasta *schemas*, através do comando:
```cmd
cd schemas
```

##### 1 - Comparação entre arquivos *.graphql* :
#
```cmd
graphql-inspector diff schema.graphql schemaV1.graphql
```
![alt text](https://github.com/mathiasosmar1/graphql-inspector-dotnet/blob/master/assets/graphql-inspector-diff-sample-one.png?raw=true)

##### 2 - Comparação entre arquivo *.graphql* e *api*:
#
```cmd
graphql-inspector diff schema.graphql http://localhost:5000/graphql
```
![alt text](https://github.com/mathiasosmar1/graphql-inspector-dotnet/blob/master/assets/graphql-inspector-diff-sample-one.png?raw=true)

##### 3 - Comparação entre *api's*:
#
```cmd
graphql-inspector diff http://localhost:5000/graphql http://localhost:5000/graphql
```
![alt text](https://github.com/mathiasosmar1/graphql-inspector-dotnet/blob/master/assets/graphql-inspector-no-diff-sample.png?raw=true)

Neste exemplo foram abordados os comandos *introspect* e *diff* do *graphql-inspector*, para saber mais da ferramenta, acesse o seu repositório do GitHub ou a documentação do site oficial, através dos links abaixo.

## Links

  - [Documentação][site-graphql-inspector]
  - [GitHub] [repo-graphql-inspector]
  
   [repo-graphql-inspector]: <https://github.com/kamilkisiela/graphql-inspector/>
   [site-graphql-inspector]: <https://graphql-inspector.com>
   [npm-url]: <https://docs.npmjs.com/>

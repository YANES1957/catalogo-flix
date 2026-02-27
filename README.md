# 🟣 Catalogo-Flix - Desafio Microsoft

## Introdução
🟣 Este projeto foi desenvolvido como parte do **desafio da Microsoft** para testar habilidades em **desenvolvimento de APIs serverless** utilizando **Azure Functions** e tecnologias do ecossistema .NET. O objetivo é criar uma API para **gerenciamento de registros de catálogo**, permitindo **inserir, listar e testar funcionalidades** de forma prática e escalável.

---

## Tecnologias Utilizadas
🟣 **Backend / Serverless**
- **.NET 7** - Runtime principal da aplicação.
- **Azure Functions (Isolated Worker)** - Arquitetura serverless para execução de funções HTTP.
- **C#** - Linguagem de programação para implementação das funções.
- **Microsoft.Extensions.Logging** - Logging estruturado das funções.

🟣 **Ferramentas**
- **Visual Studio Code** - IDE para desenvolvimento.
- **Azure Functions Core Tools v4** - Para rodar, depurar e testar localmente as funções.
- **Git/GitHub** - Controle de versão e deploy do projeto.
- **Postman / Insomnia** - Testes dos endpoints HTTP.

---

## Estrutura do Projeto
🟣 Estrutura principal:


catalogo-flix/
├── bin/ # Builds geradas
├── obj/ # Objetos intermediários
├── catalogo-flix.csproj
├── local.settings.json # Configurações locais (não versionado)
├── host.json # Configuração do host do Azure Functions
├── Functions/
│ ├── AdicionarRegistro.cs
│ ├── ListarRegistros.cs
│ └── TesteFuncao.cs
├── .gitignore
└── README.md


---

## Endpoints Disponíveis
🟣 A API disponibiliza as seguintes funções HTTP:

| Função | Método | URL |
|--------|--------|-----|
| AdicionarRegistro | POST | http://localhost:7071/api/registros/adicionar |
| ListarRegistros   | GET  | http://localhost:7071/api/registros/listar |
| TesteFuncao       | GET/POST | http://localhost:7071/api/TesteFuncao |

### Testes de Endpoints
- **AdicionarRegistro**  
  - **POST**  
  - Payload JSON:
    ```json
    {
      "nome": "Filme Exemplo",
      "ano": 2026,
      "categoria": "Ação"
    }
    ```
  - Retorno esperado: status **200 OK** e registro salvo.

- **ListarRegistros**  
  - **GET**  
  - Retorno esperado: JSON com todos os registros cadastrados.

- **TesteFuncao**  
  - **GET/POST**  
  - Retorno esperado: mensagem de teste confirmando que a função está ativa.

---

## Como Rodar Localmente
🟣 Passo a passo:

1. Instalar [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
2. Instalar [Azure Functions Core Tools v4](https://learn.microsoft.com/azure/azure-functions/functions-run-local)
3. Clonar o repositório:
   ```bash
   git clone https://github.com/seu-usuario/catalogo-flix.git
   cd catalogo-flix

Restaurar dependências:

dotnet restore

Rodar a função localmente:

func start

Testar endpoints via Postman ou navegador (GET).

Observações Técnicas

🟣 - O projeto utiliza isolated worker model, que permite maior controle sobre o pipeline de execução das funções.

Host.json está configurado para version 2.0 e bundle de extensões Azure Functions.

Local.settings.json contém variáveis de ambiente locais e não deve ser enviado para o GitHub.

Logs das funções são gerados via ILogger para facilitar debugging e monitoramento.

Preparado para deploy em Azure Functions sem alterações adicionais.

Contato / Autor

🟣 Desenvolvido por Roberto Césa Yanes – projeto pessoal para desafio técnico Microsoft.
Teste commit assinado - Verified

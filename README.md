Gerenciador de Catálogos da Netflix com Azure Functions e Banco de Dados
Este projeto foi desenvolvido como parte do curso "Criando um Gerenciador de Catálogos da Netflix com Azure Functions e Banco de Dados" oferecido pela Digital Innovation One. O objetivo é implementar um sistema simples e escalável para gerenciar catálogos de filmes e séries da Netflix utilizando recursos da plataforma Microsoft Azure.

🛠 Tecnologias Utilizadas
Azure Functions: Serviço de computação serverless para criar APIs escaláveis e de alta performance.
Banco de Dados Azure (Cosmos DB): Banco de dados NoSQL para armazenamento dos catálogos de filmes e séries.
.NET Core: Framework para desenvolvimento das funções e integração com o banco de dados.
Visual Studio Code: IDE para desenvolvimento e depuração do projeto.
⚙️ Funcionalidades do Projeto
Adicionar Catálogo: Permite a inclusão de novos filmes ou séries no catálogo.
Listar Catálogos: Recupera e exibe todos os itens do catálogo.
Atualizar Catálogo: Altera informações de um item existente.
Remover Catálogo: Exclui um item do catálogo.
API REST: Disponibiliza endpoints para consumir as funcionalidades do gerenciador.
🚀 Como Executar o Projeto
Pré-requisitos
Conta ativa no Microsoft Azure.
Azure CLI instalado.
Visual Studio Code com extensão Azure Functions.
SDK do .NET Core instalado.
Passos para Configuração
Clone o repositório:

bash
Copiar código
git clone <URL_DO_REPOSITORIO>
cd <NOME_DO_PROJETO>
Configure o ambiente:

Instale as dependências do projeto.
Crie um recurso Azure Functions no portal Azure.
Configure o Cosmos DB para armazenar os dados.
Execute o projeto localmente:

bash
Copiar código
func start
Publique no Azure:

bash
Copiar código
func azure functionapp publish <NOME_DA_APLICACAO>
Endpoints Disponíveis
Método	Endpoint	Descrição
GET	/api/catalogs	Lista todos os catálogos
POST	/api/catalogs	Adiciona um novo catálogo
PUT	/api/catalogs/{id}	Atualiza informações do item
DELETE	/api/catalogs/{id}	Remove um item do catálogo
📚 Estrutura do Projeto
plaintext
Copiar código
├── CatalogManager/
│   ├── Functions/
│   │   ├── CreateCatalog.cs
│   │   ├── GetCatalogs.cs
│   │   ├── UpdateCatalog.cs
│   │   └── DeleteCatalog.cs
│   ├── Models/
│   │   └── Catalog.cs
│   ├── Services/
│   │   └── CatalogService.cs
│   └── Program.cs
├── host.json
├── local.settings.json
└── README.md

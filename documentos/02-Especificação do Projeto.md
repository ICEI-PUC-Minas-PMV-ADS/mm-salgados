# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Arquitetura e Tecnologias
Para este projeto iremos criar uma aplicação que se estrutura da seguinte forma:

![Arquitetura da solução](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t5-MM-Salgados/blob/main/documentos/img/Arquitetura.jpg)


Serão utilizados no desenvolvimento:

Linguagens de progamação:

- C#: Linguagem de progamação utilizada para desenvolvimento do backend da solução.
- Javascript: Linguagem de progamação utilizada no frontend para a implementação de certas funcionalidades.

Frameworks:

- ASP.NET Core MVC: Framework implementando o padrão Model-View-Controller, será utilizado como base para desenvolvimento da solução.
- Entity Framework Core: Framework de mapeamento objeto-relacional (técnica utilizada para resolver o problema da impedância entre o modelo orientado a objetos e o modelo relacional) para a plataforma .NET, será utilizado para facilitar a manipulação e consulta do banco de dados relacional utilizado aplicação.

APIs:

- ASP.NET Core Identity: API que dá suporte a funcionalidade de login da interface do usuário. Será utilizado para implementar a função de login e autenticação do usuário, além da separação das contas por tipos de usuários.

IDE:

- Visual Studio Community 2022, escolhido pela integração com o Framework ASP.NET e outras ferramentas utilizadas no projeto como o SQL Server.

Sistema gerenciador de banco de dados:

- SQL Server, escolhido por sua boa integração com o editor de código e para facilitar a migração do banco de dados para o serviço de hospedagem nas fases mais avançadas do projeto.

Outras tecnologias:

HTML: Linguagem de marcação utilizada para a construção das páginas web.
CSS: Linguagem de folhas de estilos utilizada para aplicar estilos nos elementos HTML.
Razor: Sintaxe de marcação que permite inserir código baseado em .NET em páginas web junto ao HTML.

## Project Model Canvas

![MM_MODELO CANVAS](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t5-MM-Salgados/assets/101661631/eed3e86c-193b-45a5-91b8-71c7892f15cb)


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A plataforma deve permitir que o administrador crie uma conta de usuário administrativa, a qual será utilizada para cadastrar e gerenciar os produtos disponíveis.  | ALTA | 
|RF-002| A plataforma deve apresentar um catálogo completo de salgados disponíveis para compra, com descrições detalhadas, imagens atrativas e preços atualizados.   | ALTA |
|RF-003| Deve haver um sistema de suporte ao cliente integrado ao site, oferecendo canais de comunicação como chat, e-mail ou telefone, para responder dúvidas, resolver problemas e fornecer assistência durante e após a compra.    | ALTA |
|RF-004| Deve ser implementado um sistema onde os clientes possam deixar avaliações e comentários sobre os salgados que compraram, bem como sobre a experiência geral de compra no site. | ALTA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A plataforma deve ser compatível com uma variedade de dispositivos e navegadores, garantindo que os clientes possam acessá-lo independentemente do dispositivo que estejam usando.  | ALTA | 
|RNF-002| A plataforma deve ser rápido e responsivo, garantindo tempos de carregamento rápidos e uma experiência de usuário fluida, mesmo em conexões de internet mais lentas. |  ALTA | 
|RNF-003| Deve ser implementado um padrão de segurança para proteger os dados do administrador, utilizando criptografia e padrões de segurança de dados.  |  ALTA | 
|RNF-004| A plataforma deve ser dimensionável para lidar com picos de tráfego, como horários de pico de pedidos, sem comprometer o desempenho.  |  ALTA | 
|RNF-005| Deve ser projetado com uma interface intuitiva e fácil de usar, com navegação clara e elementos de design intuitivos, facilitando a busca dos produtos pelos clientes.  |  ALTA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| A plataforma pode ser acessado apenas por dispositivos compatíveis, como smartphones, tablets e computadores, que tenham acesso à internet e suportem os navegadores e aplicativos relevantes.  |
|02| O desenvolvimento da plataforma deve ser concluído dentro de um prazo definido, levando em consideração os objetivos de negócio e as expectativas dos clientes.         |
|03| A plataforma deve ser desenvolvida utilizando tecnologias específicas, como uma plataforma de e-commerce ou linguagens de programação específicas, conforme determinado pela equipe de desenvolvimento e pelos requisitos do projeto.         |
|04| A plataforma deve ser desenvolvida levando em consideração as restrições de infraestrutura existentes, como limitações de hardware, largura de banda de rede e capacidade de armazenamento, garantindo que a infraestrutura suporte adequadamente as necessidades do site.  |

## Diagrama de Casos de Uso
![Diagrama de caso de uso - M M Salgados(1)](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t5-MM-Salgados/assets/101661631/857fc84f-2c8a-4aa5-9157-939e64711855)

## Matriz de Rastreabilidade
Uma matriz de rastreabilidade nada mais é do que uma forma de visualização do relacionamento entre os requisitos. Por meio dela, são listados os requisitos nas linhas e nas colunas da matriz, depois se aplica um X nas células correspondentes, caracterizando os relacionamentos entre os requisitos. Dessa forma, podemos utilizar para efeitos de ilustração, um sistema com quatro requisitos. 

![Matriz-Rastreabilidade - M M Salgadors](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t5-MM-Salgados/assets/100872927/8a2781c3-d4b4-4143-bafd-6ad43654f272)

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

> - ![Como fazer um diagrama entidade relacionamento | Lucidchart](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t5-MM-Salgados/blob/main/documentos/img/WhatsApp%20Image%202024-03-01%20at%2016.12.07.jpeg)

## Projeto da Base de Dados

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t5-MM-Salgados/blob/main/documentos/img/Esquema.jpg)

## Gerenciamento de Tempo

O gráfico de Gantt é uma ferramenta de gerenciamento de projetos que exibe visualmente as atividades do projeto ao longo do tempo, ele ajuda os gerentes de projeto a visualizar o cronograma do projeto, identificar possíveis problemas e ajustar o plano do projeto, se necessário. Ele também permite que as equipes trabalhem de forma mais eficiente, fornecendo uma visão geral do progresso do projeto e das tarefas pendentes. 

Trazendo para nosso contexto, o gráfico de Gantt é uma representação gráfica das atividades envolvidas no desenvolvimento do aplicativo, mostrando as datas de início e término previstas para cada atividade. 

Para esse fim, construímos o gráfico de Gantt conforme disposto na figura 3. Ele contém uma lista de tarefas ou atividades na vertical e um eixo horizontal que representa o tempo. As barras horizontais representam a duração de cada atividade e a posição das barras no eixo do tempo indica quando cada atividade deve começar e terminar.


> - ![Como fazer um diagrama entidade relacionamento | Lucidchart](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t5-MM-Salgados/blob/main/documentos/img/WhatsApp%20Image%202024-02-29%20at%2018.15.17.jpeg)

> - ![Como fazer um diagrama entidade relacionamento | Lucidchart](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t5-MM-Salgados/blob/main/documentos/img/WhatsApp%20Image%202024-02-29%20at%2018.15.17%20(1).jpeg)

## Gestão de Orçamento

O processo de determinar o orçamento do projeto é uma tarefa que depende, além dos produtos (saídas) dos processos anteriores do gerenciamento de custos, também de produtos oferecidos por outros processos de gerenciamento, como o escopo e o tempo.

> - ![Como fazer um diagrama entidade relacionamento | Lucidchart](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t5-MM-Salgados/blob/main/documentos/img/WhatsApp%20Image%202024-02-29%20at%2018.15.17%20(1).jpeg)

# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Arquitetura e Tecnologias

o	Descreva brevemente a arquitetura definida para o projeto e as tecnologias a serem utilizadas. Sugere-se a criação de um diagrama de componentes da solução.

## Project Model Canvas

![MM_MODELO CANVAS](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t5-MM-Salgados/assets/101661631/eed3e86c-193b-45a5-91b8-71c7892f15cb)


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir que o administrador crie uma conta de usuário administrativa, a qual será utilizada para cadastrar e gerenciar os produtos disponíveis.  | ALTA | 
|RF-002| O site deve apresentar um catálogo completo de salgados disponíveis para compra, com descrições detalhadas, imagens atrativas e preços atualizados.   | ALTA |
|RF-003| Deve haver um sistema de suporte ao cliente integrado ao site, oferecendo canais de comunicação como chat, e-mail ou telefone, para responder dúvidas, resolver problemas e fornecer assistência durante e após a compra.    | ALTA |
|RF-004| Deve ser implementado um sistema onde os clientes possam deixar avaliações e comentários sobre os salgados que compraram, bem como sobre a experiência geral de compra no site. | ALTA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser compatível com uma variedade de dispositivos e navegadores, garantindo que os clientes possam acessá-lo independentemente do dispositivo que estejam usando.  | ALTA | 
|RNF-002| O site deve ser rápido e responsivo, garantindo tempos de carregamento rápidos e uma experiência de usuário fluida, mesmo em conexões de internet mais lentas. |  ALTA | 
|RNF-003| Deve ser implementado um padrão de segurança para proteger os dados do administrador, utilizando criptografia e padrões de segurança de dados.  |  ALTA | 
|RNF-004| O sistema deve ser dimensionável para lidar com picos de tráfego, como horários de pico de pedidos, sem comprometer o desempenho.  |  ALTA | 
|RNF-005| Deve ser projetado com uma interface intuitiva e fácil de usar, com navegação clara e elementos de design intuitivos, facilitando a busca dos produtos pelos clientes.  |  ALTA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O sistema pode ser acessado apenas por dispositivos compatíveis, como smartphones, tablets e computadores, que tenham acesso à internet e suportem os navegadores e aplicativos relevantes.  |
|02| O desenvolvimento do site deve ser concluído dentro de um prazo definido, levando em consideração os objetivos de negócio e as expectativas dos clientes.         |
|03| O site deve ser desenvolvido utilizando tecnologias específicas, como uma plataforma de e-commerce ou linguagens de programação específicas, conforme determinado pela equipe de desenvolvimento e pelos requisitos do projeto.         |
|04| O site deve ser desenvolvido levando em consideração as restrições de infraestrutura existentes, como limitações de hardware, largura de banda de rede e capacidade de armazenamento, garantindo que a infraestrutura suporte adequadamente as necessidades do site.  |

## Diagrama de Casos de Uso
![Diagrama de caso de uso - M M Salgados(1)](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t5-MM-Salgados/assets/101661631/857fc84f-2c8a-4aa5-9157-939e64711855)

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

Sugestão de ferramentas para geração deste artefato: LucidChart e Draw.io.

A referência abaixo irá auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart]([documentos/img/WhatsApp Image 2024-03-01 at 16.12.07.jpeg](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t5-MM-Salgados/assets/101661631/857fc84f-2c8a-4aa5-9157-939e64711855))

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.

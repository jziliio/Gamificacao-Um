# Sistema de Gerenciamento de Vendas de Loja de Roupas - README

Este é um projeto de um Sistema de Gerenciamento de Vendas para uma Loja de Roupas. O sistema foi desenvolvido em linguagem C# e permite a gestão de produtos, categorias, clientes e vendas, oferecendo uma interface de linha de comando para interação.

## Classes Básicas

O sistema é composto pelas seguintes classes básicas:

- **Produto**: Representa os produtos disponíveis na loja. Possui atributos como nome, descrição, preço e categoria.
- **Categoria**: Representa as categorias de produtos na loja. Contém atributos como nome e descrição.
- **Cliente**: Representa os clientes da loja. Possui informações como nome, sobrenome, endereço e telefone.
- **Venda**: Representa uma transação de venda. Inclui o cliente, os produtos vendidos, a data e o valor total da compra.

## Requisitos

Para executar este projeto, você precisa ter um ambiente de desenvolvimento C configurado em sua máquina, com um compilador C instalado.

## Instruções de Execução

1. Clone o repositório do projeto:
```bash
git clone https://github.com/jziliio/Gamificacao-Um.git
```

2. Acesse o diretório do projeto:
```bash
cd Gamificacao-Um
```

3. Compile o programa (substitua "main.c" pelo nome do arquivo principal, se necessário):
```bash
gcc main.c -o sistema_vendas
```

4. Execute o programa:
```bash
./sistema_vendas
```

Funcionalidades
O programa oferece as seguintes funcionalidades:

1. Gerenciar Categorias
- Registrar uma nova categoria.
- Alterar informações de uma categoria.
- Listar todas as categorias cadastradas.
- Buscar uma categoria pelo ID.
- Remover uma categoria.
  
2. Gerenciar Produtos
- Registrar um novo produto com informações detalhadas.
- Alterar informações de um produto.
- Listar todos os produtos cadastrados.
- Buscar um produto pelo ID.
- Remover um produto.

3. Gerenciar Clientes
- Registrar um novo cliente com detalhes.
- Alterar informações de um cliente.
- Listar todos os clientes cadastrados.
- Buscar um cliente pelo ID.
- Remover um cliente.

5. Realizar Venda
- Selecionar um cliente.
- Adicionar produtos à venda.
- Calcular e exibir o valor total da venda.
- Finalizar a venda, armazenando os detalhes.






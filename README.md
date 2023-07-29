<h1 align="center"> Sistema de Gestão de Pedidos </h1>

<p align="center">
Neste projeto eu construi um pequeno Sistema de Gestão de Pedidos, otimizado para permitir que os usuários insiram e gerenciem detalhes do cliente e do pedido de forma eficiente, com suporte para a inclusão de múltiplos itens por pedido. O sistema é projetado para fornecer um resumo abrangente de cada pedido, contribuindo para uma gestão eficaz.

O projeto foi implementado como uma solução para um desafio apresentado durante um curso de C#. Utilizando a linguagem C# - um pilar fundamental da plataforma .NET da Microsoft -, exploramos e aplicamos conceitos avançados de programação, reforçando nossa proficiência no desenvolvimento orientado a objetos e aprimorando nossa capacidade de criar soluções complexas e eficientes.
  
<p align="center">
  <a href="#-tecnologias">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-projeto">Projeto</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-aprendizado">Aprendizado</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
 
</p>


<br>


<p align="center">
  <img alt="design" src= "https://private-user-images.githubusercontent.com/118849369/256962438-35a09626-39cd-4176-8166-4c2531714b22.gif?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTEiLCJleHAiOjE2OTA2MDM0NTAsIm5iZiI6MTY5MDYwMzE1MCwicGF0aCI6Ii8xMTg4NDkzNjkvMjU2OTYyNDM4LTM1YTA5NjI2LTM5Y2QtNDE3Ni04MTY2LTRjMjUzMTcxNGIyMi5naWY_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNzI5JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDcyOVQwMzU5MTBaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT00OTMyMmNiY2ExZDdhNGY2YTkzN2M3YmEwNTdlNjc3YTRhYmEzZDAzYzg5MGFiM2FiZDU4Y2U4MzI0ZTU1MTU0JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCZhY3Rvcl9pZD0wJmtleV9pZD0wJnJlcG9faWQ9MCJ9.-OiwdSHfsv5y7Bg2JtcMdVvHMk6OuTzGotslBbL_G34">
</p>

## 🚀 Tecnologias

Esse projeto foi desenvolvido com as seguintes tecnologias:

- C#
- .NET Framework
- Git e Github

## 💻 Projeto

O usuário é inicialmente solicitado a inserir detalhes sobre o cliente, como nome, email e data de nascimento. Esses detalhes são usados para criar uma nova instância da classe Client.

Em seguida, o programa pede ao usuário para inserir os detalhes do pedido, incluindo o status do pedido. Esses detalhes são usados para criar uma nova instância da classe Order, que também contém os dados do cliente recém-criado e a data e hora atuais do sistema.

Posteriormente, o programa solicita ao usuário que insira quantos itens o pedido deve ter. Para cada item, o sistema solicita o nome do produto, preço e quantidade. Cada item é uma nova instância da classe Product, que é adicionada ao pedido através do método AddItem.

Por fim, o programa imprime um resumo do pedido, incluindo detalhes de cada item, subtotal de cada item e total geral do pedido.

## 📝 Aprendizado

O desenvolvimento deste projeto proporcionou uma excelente oportunidade para reforçar e aprofundar a compreensão dos fundamentos da programação em C#, incluindo o uso de classes, métodos, loops e manipulação de strings.

Foi possível aprender como solicitar e manipular dados do usuário, criar e manipular objetos, e usar listas para armazenar e manipular coleções de objetos. Além disso, este projeto permitiu praticar o uso de formatos de data e hora, e a utilização de enumeradores para representar um conjunto de valores fixos.

Finalmente, o projeto exigiu a criação e uso de métodos personalizados dentro de classes para realizar cálculos e manipular dados, e a sobreposição do método ToString para fornecer uma representação personalizada dos objetos.

Este projeto foi um desafio gratificante e uma excelente oportunidade de aprendizado, resultando em um sistema útil e funcional para gerenciar pedidos.

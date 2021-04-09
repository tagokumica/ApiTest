# Desafio Iti Digital

## Descrição
Considere uma senha sendo válida quando a mesma possuir as seguintes definições:

- Nove ou mais caracteres
- Ao menos 1 dígito
- Ao menos 1 letra minúscula
- Ao menos 1 letra maiúscula
- Ao menos 1 caractere especial
- Considere como especial os seguintes caracteres: !@#$%^&*()-+
- Não possuir caracteres repetidos dentro do conjunto

### Pontos que daremos maior atenção

- [x] Testes de unidade / integração
- [x] Abstração, acoplamento, extensibilidade e coesão
- [x] Design de API
- [x] Clean Code
- [x] SOLID
- [x] Documentação da solução no README


### Como rodar o projeto:

O projeto foi todo testado via Visual Studio 2019, então para a execução é recomendado rodar e debugar via Visual Studio tambem.


### Decisōes de Arquitetura

O projeto foi desenvolvido usando .Net 5.
Contem as camadas de API, e Application e IoC(Injecao de dependencias)

Foi criada uma camada de testes unitarios para a camada Application e outra para testes integrados para a camada de API

#### Design de Codigo

Foi utilizada uma estrategia de ValidationPattern para as regras
de validacao de senha, deixando uma engine de validacao extensivel, assim para adicionar ou remover uma regra de validacao basta alterar o registro do da instancia de `UserValidate` na injencao de dependencias.
Dessa forma tambem as regras ficam isoladas e podem ser testadas separadamente, onde uma regra não depende ou será impactada por outra.

#### Exemplo de uso da API:

http
POST /api/usuario/validar-senha
Content-Type: application/json

{
    "password": "AbTp9!fok"
}
```
e a resposta deve ser conter `status-code: 200` e `body: true`

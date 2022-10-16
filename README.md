# Employee Jurney

Desafio da aula de Linguagem de Programação IV

## Roteiro 
```
Um determinado cliente deseja realizar o mapa de características de seus colaboradores, com o propósito de se ter uma ferramenta mais poderosa e assertiva de feedbacks e acompanhamento da evolução de cada pessoa do time. 

Para isso, a empresa gostaria de registrar:
• Nome e dados atualizados de cada colaborador;
• História do colaborador na empresa: cargos que ocupou, datas, promoções;
• Registro de feedbacks: Com datas, pontos fortes e fracos mapeados para o colaborador, ações esperadas e metas.

-> Entendido o problema acima, construa uma Aplicação WEB que resolva o problema do cliente. 
```

## Estrutura do Banco

### Tabelas: 
- employee (id_employee, name, data)
- employee_history (id_employee_history, id_employee, position, created_on)
- employee_feedback (id_employee_feedback, id_employee, feedback, created_on)
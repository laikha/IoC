# IoC

Implementação simples de inversão de controle e metadata de tipo.

## Sobre

Este projeto contém uma interface genérica `I4IoC<T>` e uma classe base abstrata `BasicClassInversion<T>` que expõe operações básicas sobre o tipo genérico `T`.

## Funcionalidades

- `WhoAmI()` retorna o nome do tipo genérico `T`.
- `WhoAmI(T whoIs)` retorna o nome do tipo da instância fornecida.
- `NotInitialized(T whoIs)` valida se o objeto foi instanciado e lança exceção quando necessário.
- `GetMidGrade()` é um método abstrato na classe base e deve ser implementado por classes derivadas.

> Observação: esta implementação não é um container IoC completo, mas sim um ponto de partida para trabalhar com tipos genéricos e validação de inicialização.

## Status

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=laikha_IoC&metric=alert_status)](https://sonarcloud.io/dashboard?id=laikha_IoC)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=laikha_IoC&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=laikha_IoC) [![Bugs](https://sonarcloud.io/api/project_badges/measure?project=laikha_IoC&metric=bugs)](https://sonarcloud.io/dashboard?id=laikha_IoC) [![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=laikha_IoC&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=laikha_IoC) [![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=laikha_IoC&metric=ncloc)](https://sonarcloud.io/dashboard?id=laikha_IoC) [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=laikha_IoC&metric=code_smells)](https://sonarcloud.io/dashboard?id=laikha_IoC)

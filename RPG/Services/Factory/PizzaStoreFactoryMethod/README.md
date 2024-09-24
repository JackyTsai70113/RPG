# Factory Method

1. 所有 ConcreteProduct 必須實現 Product。
2. Creator 定義工廠方法但不實作，且實現了操作 Product 的方法。
3. 所有 ConcreteCreator 必須實現 Creator。
4. ConcreteCreator 負責創建 ConcreteProduct，也只有他才有 ConcreteProduct 的視野。

```mermaid
classDiagram
    direction LR
    NYStyleCheesePizza --|> Pizza
    NYStyleClamPizza --|> Pizza
    NYStylePepperoniPizza --|> Pizza
    NYStyleVeggiePizza --|> Pizza
    ChicagoStyleCheesePizza --|> Pizza
    ChicagoStyleClamPizza --|> Pizza
    ChicagoStylePepperoniPizza --|> Pizza
    ChicagoStyleVeggiePizza --|> Pizza
    <<interface>> Pizza
    NYPizzaStore --|> PizzaStore
    ChicagoPizzaStore --|> PizzaStore
    <<interface>> PizzaStore
    class PizzaStore {
        CreatePizza() Pizza 
        OrderPizza() Pizza
    }
    class NYPizzaStore {
        CreatePizza() Pizza 
    }
    class ChicagoPizzaStore {
        CreatePizza() Pizza 
    }
```

```mermaid
---
title: ---
---
classDiagram
    direction LR
    ConcreteProduct --|> Product
    <<interface>> Product
    ConcreteCreator --|> Creator
    <<interface>> Creator
    class Creator {
        FactoryMethod() Product 
        Operation()
    }
    class ConcreteCreator {
        FactoryMethod() Product 
    }
```

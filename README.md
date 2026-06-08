# Civir.Domain

Librería de clases .NET para el dominio de Civir.

Provee entidades, objetos de valor y reglas de negocio básicas para modelar pedidos, clientes y datos de contacto.

## Características

- Entidad base genérica (`Entity<TId>`)
- Objeto de valor base (`ValueObject`)
- Tipos de dominio como `CorreoElectronico`, `Direccion`, `PedidoItem` y `Pedido`
- Estados de pedido y operaciones de transición de estado

## Requisitos

- .NET 10.0

## Uso

1. Clona el repositorio o agrega el paquete a tu solución.
2. Agrega la referencia al proyecto `Civir.Domain`.
3. Importa el espacio de nombres:

```csharp
using Civir.Domain;
```

4. Usa las clases de dominio en tu lógica de aplicación:

```csharp
var pedido = new Pedido(
    id: Guid.NewGuid(),
    clienteId: Guid.NewGuid(),
    items: new[]
    {
        new PedidoItem("Producto A", 2, 50m),
        new PedidoItem("Producto B", 1, 120m)
    }
);

pedido.Confirmar();
pedido.Enviar();
```

## Construcción

```bash
dotnet build
```

## Paquete NuGet

El proyecto está configurado para generar un paquete NuGet al compilar:

- `PackageId`: `ProcLog.Civir.Domain`
- `Version`: `0.0.1`
- `Authors`: `Juan Manuel Carreño`
- `Company`: `Procesos Logicos`
- `PackageLicenseExpression`: `MIT`

## Contribuciones

Aporta mejoras mediante pull requests o abre un issue para sugerir cambios.

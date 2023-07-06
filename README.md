## Add migration

In `Warehouse.Infrastructure` execute below command

```bash
dotnet ef migrations add Init_Read --context ReadDbContext --startup-project ../Warehouse.Api/ -o EF/Migrations
```
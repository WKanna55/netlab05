# Lab04 NET - Inicializar proyecto

1. Crear una base de datos en postgres con el nombre TecsupDB

2. Abrir consola cmd y ejecutar estos comandos:

`D:`
`cd ruta\proyecto\proyecto.Infrastructure\Data\`
`psql -U postgres -d TecsupDB -f db.sql`
`psql -U postgres -d TecsupDB -f insert.sql`

_Opcional: comando para hacer scaffold, ubicarse en la raiz de la solucion (no en un proyecto en especifico)_

`dotnet ef dbcontext scaffold "Host=localhost;Port=5432;Database=TecsupDB;Username=postgres;Password=root;" Npgsql.EntityFrameworkCore.PostgreSQL --project LAB05-WillianK.Infrastructure --output-dir Scaffold/Entities --context-dir Scaffold/Context --context ApplicationDbContext --no-pluralize --force`


3. Ejecutar aplicacion
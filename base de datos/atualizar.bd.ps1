# Script para actualizar automáticamente el archivo main.sql con el esquema actual de la base de datos
# Ejecutar en PowerShell como administrador después de hacer cambios en la base de datos local

$PG_PATH = "C:\Program Files\PostgreSQL\17\bin\pg_dump.exe"
$PORT = 2525
$USER = "postgres"
$DB = "sistema_inventario"
$OUTPUT_FILE = "main.sql"

Write-Host "Actualizando $OUTPUT_FILE con el esquema actual de la base de datos..."
& $PG_PATH -p $PORT -U $USER -d $DB --schema-only -f $OUTPUT_FILE

Write-Host "Esquema actualizado en $OUTPUT_FILE. Recuerda hacer commit y push a GitHub."
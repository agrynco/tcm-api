docker-compose -f docker-compose_development.yml -p tcm_develop up -d

SET currentPath=%~dp0

REM CD ..\..\DAL.EF\

REM update_db_with_migrator-Development.bat

CD currentPath 
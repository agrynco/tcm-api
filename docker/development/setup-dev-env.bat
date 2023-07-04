docker-compose -f docker-compose_development.yml -p tcm_develop up -d

SET currentPath=%~dp0

CD ..\..\DAL.EF\

update_db_with_migrator-Development.bat

CD currentPath 
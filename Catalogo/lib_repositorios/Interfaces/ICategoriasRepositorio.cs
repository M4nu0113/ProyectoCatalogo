﻿using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ICategoriasRepositorio
    {
        List<Categorias> Listar();
        List<Categorias> Buscar(Expression<Func<Categorias, bool>> condiciones);
        Categorias Guardar(Categorias entidad);
        Categorias Modificar(Categorias entidad);
        Categorias Borrar(Categorias entidad);
    }
}
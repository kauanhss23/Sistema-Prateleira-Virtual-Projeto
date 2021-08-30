import React from 'react'
import { useState } from 'react';
import './alterlivfunc.css';

import { ToastContainer, toast} from "react-toastify";
import api from '../../Services/FuncoesFuncionario'

export default function AlterarLivroFunc(props){

  const funcoesfuncionario = new api();
  const [livro,setLivro] = useState(props.location.state.livro);
  const [autor,setAutor] = useState(props.location.state.autor);
  const [genero,setGenero] = useState(props.location.state.genero);
  const [preco,setPreco] = useState(props.location.state.preco)
  const [paginas,setPaginas] = useState(props.location.state.paginas);
  const [idioma,setIdiomaprimario] = useState(props.location.state.idiomaprimario);
  const [sinopse,setSinopse] = useState(props.location.state.sinopse);
  const [publicacao,setPublicacao] = useState(new Date(props.location.state.publicacao).toLocaleDateString());
  const [editora,setEditora] = useState(props.location.state.editora);
  const [numeroserie,setNumeroserie] = useState(props.location.state.numeroserie);
  const [edicaolivro,setEdicaolivro] = useState(props.location.state.edicaolivro);

  console.log(publicacao);
  const AtualizarRegistros = async() =>{
    try{
      const x = await funcoesfuncionario.AlterarLivro({
        idlivro:props.location.state.id,
        livro:livro,
        autor:autor,
        genero:genero, 
        preco:preco,
        paginas:paginas,
        idiomaprimario:idioma,
        sinopse:sinopse,
        publicacao:publicacao,
        editora:editora,
        numeroserie:numeroserie,
        edicaolivro:edicaolivro
      });
      toast.success("🚀 Alterado com sucesso!");
    }
    catch(ex)
    {
        if(ex.response.data.motivo)
        toast.error("😵 " + ex.response.data.motivo);
        else
        toast.error("😔 Tente Novamente");
    }

  }

    return( 
      
    <body className="telaalterar">
        <div className="manager">

          <h2 className="titulotelaalterar">Alterar Livro: </h2>

          <div className="planilha">
            <div className="entradas">
              <label>Livro: </label>
              <input type="text" value={livro} onChange={e => setLivro(e.target.value)}></input>
            </div>
            <div className="entradas">
              <label>Autor: </label>
              <input type="text" value={autor} onChange={e => setAutor(e.target.value)}></input>
            </div>
            <div className="entradas">
              <label>Genero</label>
              <input type="text" value={genero} onChange={e => setGenero(e.target.value)}></input>
            </div>
            <div className="entradas">
              <label>Preço: </label>
              <input type="number" value={preco} onChange={e => setPreco(e.target.value)}></input>
            </div>
            <div className="entradas">
              <label>Páginas: </label>
              <input type="number" value={paginas} onChange={e => setPaginas(e.target.value)}></input>
            </div>
            <div className="entradas">
              <label>Idioma Primário: </label>
              <input type="text" value={idioma} onChange={e => setIdiomaprimario(e.target.value)}></input>
            </div>
            <div className="entradas">
              <label>Sinopse: </label>
              <textarea value={sinopse} onChange={e => setSinopse(e.target.value)}></textarea>
            </div>
            <div className="entradas">
              <label>Publicação: </label>
              <input type="date" value={publicacao} onChange={e => setPublicacao(e.target.value)}></input>
            </div>
            <div className="entradas">
              <label>Editora: </label>
              <input type="text" value={editora} onChange={e => setEditora(e.target.value)}></input>
            </div>
            <div className="entradas">
              <label>Numero de Serie: </label>
              <input type="text" value={numeroserie} onChange={e => setNumeroserie(e.target.value)}></input>
            </div>
            <div className="entradas">
              <label>Edição do Livro: </label>
              <input type="text" value={edicaolivro} onChange={e => setEdicaolivro(e.target.value)}></input>
            </div>
          </div>

          <div className="botoesalterar">
            <button className="btn btn-primary" onClick={AtualizarRegistros}>Salvar Alterações</button>
            <a href="/conlivfunc" className="btn btn-dark">Voltar</a>
          </div>
        </div>
        <ToastContainer/>
    </body>
    )
} 


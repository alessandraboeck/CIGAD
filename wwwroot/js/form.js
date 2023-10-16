function validaNome()
{
    var nome = document.getElementById('inpnome');

    if(nome.value.length < 1)
    {
        alert("Adicione seu nome completo!");
        return false;
    }
    else
    {
        return true;
    }
}

function validaEmail()
{
    var email = document.getElementById("inpemail");

    if(email.value.indexOf('@') == -1)
    {
        alert("Por favor, insira um email válido!");
        return false;
    }
    else
    {
        return true;
    }
}

function validaMensagem()
{
    var mensagem = document.getElementById('inpmensagem');

    if(mensagem.value.length < 1)
    {
        alert("Por favor, insira sua mensagem!");
        return false;
    }
    else
    {
        return true;
    }
}
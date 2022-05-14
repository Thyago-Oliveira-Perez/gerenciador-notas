import { Button, Input, InputLabel, Typography, Box } from "@mui/material";

export default function InputFilePage() {

  function salvarDoc(){

    console.log("Aloha");
   
  }  

  return (
    <Box
      sx={{
        display: "flex",
        alignItems: "center",
        justifyContent: "center",
        flexDirection: "column",
        margin: "auto",
        width: "400px",
        gap: "40px",
      }}
    >
      <Typography
        sx={{
          textAlign: "center",
          width: "100%",
        }}
        variant="h4"
      >
        Inserir Documento Abaixo
      </Typography>
      <Input type="file"></Input>
      <Button
        sx={{
          width: "100%",
        }}
        variant="outlined"
        onClick={salvarDoc}
      >
        Salvar
      </Button>
    </Box>
  );
}

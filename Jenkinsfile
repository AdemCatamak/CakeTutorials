#!groovy

node {
    stage ('Checkout') {
        checkout scm
    }
    
    stage('Run Cake') {
        def statusCode = pss(".\\build.ps1 -branchName='$env.BRANCH_NAME'")
        if (statusCode != 0) {
            error("Program failed, please read logs...")
        }
    }
}


def int pss(psCmd){
  hasError = 0
  try{
    psCmd=psCmd.replaceAll("%", "%%")
    bat "powershell.exe -NonInteractive -ExecutionPolicy Bypass -Command \"\$ErrorActionPreference='Stop';[Console]::OutputEncoding=[System.Text.Encoding]::UTF8;$psCmd;EXIT \$global:LastExitCode\""
  }
  catch(Exception ex){
    hasError = 1
  }
  
  return hasError
}
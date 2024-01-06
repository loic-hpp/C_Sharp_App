param (
    [string]$userName,
    [string]$password
)

try {
    $domain = "your_domain" #TODO
    $dc = Get-ADDomainController -Discover -Service ADWS -DomainName $domain
    $user = Get-ADUser -Filter {SamAccountName -eq $userName} -Server $dc.HostName

    if ($user) {
        $credentials = New-Object System.Management.Automation.PSCredential ($userName, (ConvertTo-SecureString -String $password -AsPlainText -Force))
        $isValid = $user | Test-ADAuthentication -Credential $credentials

        if ($isValid) {
            Write-Output "Result=Valid"
        } else {
            Write-Output "Result=Invalid"
        }
    } else {
        Write-Output "Result=UserNotFound"
    }
}
catch {
    Write-Output "Result=Error"
    Write-Error $_.Exception.Message
}